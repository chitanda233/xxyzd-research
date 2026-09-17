package com.czhj.volley;

/* JADX INFO: loaded from: classes2.dex */
class ResponseDeliveryRunnable implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Request f2322a;
    private final Response b;
    private final Runnable c;

    public ResponseDeliveryRunnable(Request request, Response response, Runnable runnable) {
        this.f2322a = request;
        this.b = response;
        this.c = runnable;
    }

    @Override // java.lang.Runnable
    public void run() {
        if (this.f2322a.isCanceled()) {
            this.f2322a.finish("canceled-at-delivery");
            return;
        }
        if (this.b.isSuccess()) {
            this.f2322a.deliverResponse(this.b.result);
        } else {
            this.f2322a.deliverError(this.b.error);
        }
        if (this.b.intermediate) {
            this.f2322a.addMarker("intermediate-response");
        } else {
            this.f2322a.finish("done");
        }
        Runnable runnable = this.c;
        if (runnable != null) {
            runnable.run();
        }
    }
}
