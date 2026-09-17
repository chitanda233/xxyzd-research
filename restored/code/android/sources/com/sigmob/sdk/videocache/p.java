package com.sigmob.sdk.videocache;

/* JADX INFO: loaded from: classes4.dex */
public class p extends Exception {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3677a = ". Version: 4.25.14";

    public p(String message) {
        super(message + f3677a);
    }

    public p(String message, Throwable cause) {
        super(message + f3677a, cause);
    }

    public p(Throwable cause) {
        super("No explanation error. Version: 4.25.14", cause);
    }
}
