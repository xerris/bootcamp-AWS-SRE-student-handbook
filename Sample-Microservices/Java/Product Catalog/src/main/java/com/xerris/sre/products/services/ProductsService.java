package com.xerris.sre.products.services;

import com.xerris.sre.products.domain.Product;
import org.springframework.stereotype.Service;

import java.util.Arrays;
import java.util.Optional;
import java.util.UUID;

@Service
public class ProductsService implements IProductsService {

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
        return products;
    }

    @Override
    public Product getProduct(UUID sku) {
        Optional<Product> found = Arrays.stream(products)
                .filter(x -> x.getSku().equals(sku)).findFirst();
        if (found.isPresent())
            return found.get();
        return null;
    }
}
