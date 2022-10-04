package com.xerris.pricing.engine.services;

import com.xerris.pricing.engine.domain.Price;
import org.springframework.stereotype.Service;

import java.util.Arrays;
import java.util.Optional;
import java.util.UUID;

@Service
public class PricingService implements IPricingService {

    private Price[] prices = new Price[] {
            new Price(UUID.fromString("d18b1bdb-596a-4fd7-abe5-3bec4bcb6e4d"), 5.75, 3),
            new Price(UUID.fromString("c0c20648-ecd9-4896-999d-8c2d55010f77"), 5.75, 3.15),
            new Price(UUID.fromString("76ad06f0-8ced-401e-862d-da27b1b496bb"), 4.25, 2.75)
    };

    @Override
    public Price[] getAllPrices() { return prices; }

    @Override
    public Price getPrice(UUID sku) {
        Optional<Price> found = Arrays.stream(prices)
                .filter(x -> x.getSku().equals(sku)).findFirst();
        if (found.isPresent())
            return found.get();
        return null;
    }
}
