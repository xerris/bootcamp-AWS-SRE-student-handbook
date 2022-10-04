package com.xerris.pricing.engine.services;

import com.xerris.pricing.engine.domain.Price;

import java.util.UUID;

public interface IPricingService {
    Price[] getAllPrices();
    Price getPrice(UUID sku);
}
