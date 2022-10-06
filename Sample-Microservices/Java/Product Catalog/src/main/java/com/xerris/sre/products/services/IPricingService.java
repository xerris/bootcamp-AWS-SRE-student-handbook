package com.xerris.sre.products.services;

import com.xerris.sre.products.domain.Price;

import java.util.List;
import java.util.UUID;

public interface IPricingService {
    List<Price> getAllPrices();
    Price getPrice(UUID sku);
}

