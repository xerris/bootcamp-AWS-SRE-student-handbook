package com.xerris.pricing.engine.domain;

import java.util.UUID;

public class Price {
    public UUID getSku() { return sku; }
    public void setSku(UUID sku) { this.sku = sku; }

    public double getRetailPrice() { return retailPrice; }
    public void setRetailPrice(double retailPrice) { this.retailPrice = retailPrice; }

    public double getWholesalePrice() { return wholesalePrice; }
    public void setWholesalePrice(double wholesalePrice) { this.wholesalePrice = wholesalePrice; }

    public Price() { }

    public Price(UUID sku, double retailPrice, double wholesalePrice) {
        this.sku = sku;
        this.retailPrice = retailPrice;
        this.wholesalePrice = wholesalePrice;
    }

    private UUID sku;
    private double retailPrice;
    private double wholesalePrice;


}
