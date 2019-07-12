package com.example.demo;

import java.util.concurrent.CompletableFuture;

/**
 * Future
 */
public class Future {

    public void processAsyncMethod() {
        // Process Here
        
    }

    // public CompletableFuture<String> returnThisAsync(String thingToReturn) {

    // }

    public CompletableFuture doAsync() {
        return new CompletableFuture();
    }


























































    public CompletableFuture<String> sayHelloAsync() {
        return CompletableFuture.supplyAsync(() -> "Hello");
    }

    public CompletableFuture<String> sayWorldAsync() {
        return CompletableFuture.supplyAsync(() -> ", world!");
    }

    public CompletableFuture<String> sayWorldAsync(String hello) {
        return CompletableFuture.supplyAsync(() -> hello + ", world!");
    }

    public CompletableFuture<String> throwAsync() {
        return CompletableFuture.supplyAsync(() -> {
            if (true)
                throw new RuntimeException("Computation error!");
            return "I'm not here";
        });
    }
}