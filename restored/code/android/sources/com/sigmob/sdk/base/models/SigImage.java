package com.sigmob.sdk.base.models;

/* JADX INFO: loaded from: classes3.dex */
public class SigImage {
    private final int height;
    private final String imageUrl;
    private final int width;

    public SigImage(String imageUrl, int width, int height) {
        this.imageUrl = imageUrl;
        this.width = width;
        this.height = height;
    }

    public int getHeight() {
        return this.height;
    }

    public String getImageUrl() {
        return this.imageUrl;
    }

    public int getWidth() {
        return this.width;
    }
}
