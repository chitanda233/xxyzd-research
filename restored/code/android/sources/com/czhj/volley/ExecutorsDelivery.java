package com.czhj.volley;

import java.util.concurrent.ExecutorService;

/* JADX INFO: loaded from: classes2.dex */
public class ExecutorsDelivery implements ResponseDelivery {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final ExecutorService f2315a;

    public ExecutorsDelivery(ExecutorService executorService) {
        this.f2315a = executorService;
    }

    @Override // com.czhj.volley.ResponseDelivery
    public void postError(Request<?> request, VolleyError volleyError) {
        request.addMarker("post-error");
        this.f2315a.execute(new ResponseDeliveryRunnable(request, Response.error(volleyError), null));
    }

    @Override // com.czhj.volley.ResponseDelivery
    public void postResponse(Request<?> request, Response<?> response) {
        postResponse(request, response, null);
    }

    @Override // com.czhj.volley.ResponseDelivery
    public void postResponse(Request<?> request, Response<?> response, Runnable runnable) {
        request.markDelivered();
        request.addMarker("post-response");
        this.f2315a.execute(new ResponseDeliveryRunnable(request, response, runnable));
    }
}
