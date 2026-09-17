package com.czhj.volley;

import android.os.Handler;
import java.util.concurrent.Executor;

/* JADX INFO: loaded from: classes2.dex */
public class ExecutorDelivery implements ResponseDelivery {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Executor f2313a;

    public ExecutorDelivery(final Handler handler) {
        this.f2313a = new Executor() { // from class: com.czhj.volley.ExecutorDelivery.1
            @Override // java.util.concurrent.Executor
            public void execute(Runnable runnable) {
                handler.post(runnable);
            }
        };
    }

    public ExecutorDelivery(Executor executor) {
        this.f2313a = executor;
    }

    @Override // com.czhj.volley.ResponseDelivery
    public void postError(Request<?> request, VolleyError volleyError) {
        request.addMarker("post-error");
        this.f2313a.execute(new ResponseDeliveryRunnable(request, Response.error(volleyError), null));
    }

    @Override // com.czhj.volley.ResponseDelivery
    public void postResponse(Request<?> request, Response<?> response) {
        postResponse(request, response, null);
    }

    @Override // com.czhj.volley.ResponseDelivery
    public void postResponse(Request<?> request, Response<?> response, Runnable runnable) {
        request.markDelivered();
        request.addMarker("post-response");
        this.f2313a.execute(new ResponseDeliveryRunnable(request, response, runnable));
    }
}
