package com.xerris.sre.products.domain;

import java.util.UUID;

public class Product {

    public UUID getSku() { return sku; }
    public void setSku(UUID sku) {this.sku = sku; }

    public String getName() { return name; }
    public void setName(String name) { this.name = name; }

    public String getDescription() { return description; }
    public void setDescription(String description) { this.description = description; }

    public String getManufacturer() { return manufacturer; }
    public void setManufacturer(String manufacturer) { this.manufacturer = manufacturer; }

    public Price getPrice() { return price; }
    public void setPrice(Price price) { this.price = price; }

    public Product(UUID sku, String name, String description, String manufacturer) {
        this.sku = sku;
        this.name = name;
        this.description = description;
        this.manufacturer = manufacturer;
    }

    private UUID sku;
    private String name;
    private String description;
    private String manufacturer;
    private Price price;
}

