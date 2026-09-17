package com.sigmob.sdk.downloader.core.listener;

import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public abstract class d implements com.sigmob.sdk.downloader.c, com.sigmob.sdk.downloader.core.listener.assist.b.InterfaceC0565b, com.sigmob.sdk.downloader.core.listener.assist.d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final com.sigmob.sdk.downloader.core.listener.assist.b f3451a;

    static class a implements com.sigmob.sdk.downloader.core.listener.assist.e.b<com.sigmob.sdk.downloader.core.listener.assist.b.c> {
        a() {
        }

        @Override // com.sigmob.sdk.downloader.core.listener.assist.e.b
        /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
        public com.sigmob.sdk.downloader.core.listener.assist.b.c b(int id) {
            return new com.sigmob.sdk.downloader.core.listener.assist.b.c(id);
        }
    }

    public d() {
        this(new com.sigmob.sdk.downloader.core.listener.assist.b(new a()));
    }

    d(com.sigmob.sdk.downloader.core.listener.assist.b assist) {
        this.f3451a = assist;
        assist.a(this);
    }

    public void a(com.sigmob.sdk.downloader.core.listener.assist.b.a assistExtend) {
        this.f3451a.a(assistExtend);
    }

    @Override // com.sigmob.sdk.downloader.c
    public void a(com.sigmob.sdk.downloader.f task, int blockIndex, long contentLength) {
    }

    @Override // com.sigmob.sdk.downloader.c
    public void a(com.sigmob.sdk.downloader.f task, int responseCode, Map<String, List<String>> responseHeaderFields) {
    }

    @Override // com.sigmob.sdk.downloader.c
    public final void a(com.sigmob.sdk.downloader.f task, com.sigmob.sdk.downloader.core.breakpoint.c info) {
        this.f3451a.a(task, info, true);
    }

    @Override // com.sigmob.sdk.downloader.c
    public final void a(com.sigmob.sdk.downloader.f task, com.sigmob.sdk.downloader.core.breakpoint.c info, com.sigmob.sdk.downloader.core.cause.b cause) {
        this.f3451a.a(task, info, false);
    }

    @Override // com.sigmob.sdk.downloader.c
    public final void a(com.sigmob.sdk.downloader.f task, com.sigmob.sdk.downloader.core.cause.a cause, Exception realCause) {
        this.f3451a.a(task, cause, realCause);
    }

    @Override // com.sigmob.sdk.downloader.c
    public void a(com.sigmob.sdk.downloader.f task, Map<String, List<String>> requestHeaderFields) {
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.d
    public void a(boolean isAlwaysRecoverAssistModel) {
        this.f3451a.a(isAlwaysRecoverAssistModel);
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.d
    public boolean a() {
        return this.f3451a.a();
    }

    @Override // com.sigmob.sdk.downloader.c
    public final void b(com.sigmob.sdk.downloader.f task, int blockIndex, long increaseBytes) {
        this.f3451a.a(task, blockIndex, increaseBytes);
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.d
    public void b(boolean isAlwaysRecoverAssistModel) {
        this.f3451a.b(isAlwaysRecoverAssistModel);
    }

    @Override // com.sigmob.sdk.downloader.c
    public void c(com.sigmob.sdk.downloader.f task, int blockIndex, long contentLength) {
        this.f3451a.a(task, blockIndex);
    }
}
