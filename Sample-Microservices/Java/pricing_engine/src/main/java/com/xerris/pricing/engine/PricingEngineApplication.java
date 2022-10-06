package com.xerris.pricing.engine;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.util.Collections;

@SpringBootApplication
public class PricingEngineApplication {

    public static void main(String[] args) {
        SpringApplication app = new SpringApplication(PricingEngineApplication.class);
        app.setDefaultProperties(Collections
                .singletonMap("server.port", "8081"));
        app.run(args);
    }
}
