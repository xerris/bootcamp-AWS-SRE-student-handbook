package com.xerris.sre.products.services;

import com.google.gson.Gson;
import com.squareup.okhttp.OkHttpClient;
import com.squareup.okhttp.Request;
import com.xerris.sre.products.domain.Price;
import org.springframework.stereotype.Service;

import java.io.IOException;
import java.util.Arrays;
import java.util.List;
import java.util.UUID;

@Service
public class PricingService implements IPricingService {

    private final OkHttpClient client;
    private final String url = "http://localhost:8081";

    public PricingService() {
        client = new OkHttpClient();
    }

    @Override
    public List<Price> getAllPrices() {
        var endpoint = String.format("%s/prices", url);
        var json = get(endpoint);
        Price[] prices = new Gson().fromJson(json, Price[].class);
        return Arrays.asList(prices);
    }

    @Override
    public Price getPrice(UUID sku) {
        var endpoint = String.format("%s/price/%s", url, sku.toString());
        var json = get(endpoint);
        return new Gson().fromJson(json, Price.class);
    }

    private String get(String url) {
        var request = new Request.Builder().url(url).build();
        try {
            var response = client.newCall(request).execute();
            String json = response.body().string();
            return json;
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
}
