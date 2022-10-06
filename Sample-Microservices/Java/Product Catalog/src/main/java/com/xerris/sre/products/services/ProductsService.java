package com.xerris.sre.products.services;

import com.xerris.sre.products.domain.Price;
import com.xerris.sre.products.domain.Product;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.Arrays;
import java.util.List;
import java.util.Optional;
import java.util.UUID;
import java.util.function.Predicate;

@Service
public class ProductsService implements IProductsService {

    private final IPricingService pricingService;

    @Autowired
    public ProductsService(IPricingService pricingService) {
        this.pricingService = pricingService;
    }

    private Product[] products = new Product[] {
            new Product(UUID.fromString("d18b1bdb-596a-4fd7-abe5-3bec4bcb6e4d"),
                    "Flat White Latte", "Our most popular Latte", "Coffee-Bucks"),
            new Product(UUID.fromString("c0c20648-ecd9-4896-999d-8c2d55010f77"),
                   "Pumpkin Spice Latte", "Our favorite Latte for Halloween", "Coffee-Bucks" ),
            new Product(UUID.fromString("76ad06f0-8ced-401e-862d-da27b1b496bb"),
                    "Chocolate Fudge Brownee", "Try our most popular Brownee", "Jim Hortons")
    };

    @Override
    public Product[] getAllProducts() {
        var prices = pricingService.getAllPrices();
        aggregate(products, prices);
        return products;
    }

    private void aggregate(Product[] products, List<Price> prices) {
        for (Product each : products) {
            var price = prices.stream()
                    .filter(x -> x.getSku().equals(each.getSku())).findFirst();
            price.ifPresent(each::setPrice);
        }
    }

    @Override
    public Product getProduct(UUID sku) {
        Optional<Product> found = Arrays.stream(products)
                .filter(x -> x.getSku().equals(sku)).findFirst();
        var price = pricingService.getPrice(sku);
        if (found.isPresent()) {
            var product = found.get();
            product.setPrice(price);
            return product;
        }
        return null;
    }
}
