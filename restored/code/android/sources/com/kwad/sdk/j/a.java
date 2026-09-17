package com.kwad.sdk.j;

import java.io.IOException;
import okhttp3.Interceptor;
import okhttp3.Response;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements Interceptor {
    public final Response intercept(Interceptor.Chain chain) throws Exception {
        try {
            return chain.proceed(chain.request());
        } catch (Exception e) {
            if (e instanceof IOException) {
                throw e;
            }
            throw new IOException(e);
        }
    }
}
