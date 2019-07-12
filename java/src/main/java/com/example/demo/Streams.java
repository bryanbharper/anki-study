package com.example.demo;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Map;
import java.util.stream.*;

/**
 * Streams
 */
public class Streams {
    private List<String> languages = new ArrayList<>();
    private List<Article> articles = new ArrayList<>();
    private IntStream evens;

    public Streams() {
        languages = Arrays.asList("C#", "Java", "Python", "Java");
        articles.add(new Article("Title", "Author", languages));

        evens = IntStream.iterate(0, i -> i + 2).limit(10);
    }

    public void Foo() {
        // Code

    }

    // My Foo

}