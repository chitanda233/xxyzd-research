package com.sigmob.sdk.downloader.core.listener;

/* JADX INFO: loaded from: classes3.dex */
public abstract class e extends d implements com.sigmob.sdk.downloader.core.listener.assist.c.a {

    private static class a implements com.sigmob.sdk.downloader.core.listener.assist.e.b<com.sigmob.sdk.downloader.core.listener.assist.c.b> {
        private a() {
        }

        @Override // com.sigmob.sdk.downloader.core.listener.assist.e.b
        /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
        public com.sigmob.sdk.downloader.core.listener.assist.c.b b(int id) {
            return new com.sigmob.sdk.downloader.core.listener.assist.c.b(id);
        }
    }

    public e() {
        this(new com.sigmob.sdk.downloader.core.listener.assist.c());
    }

    private e(com.sigmob.sdk.downloader.core.listener.assist.c assistExtend) {
        super(new com.sigmob.sdk.downloader.core.listener.assist.b(new a()));
        assistExtend.a(this);
        a(assistExtend);
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.b.InterfaceC0565b
    public final void a(com.sigmob.sdk.downloader.f task, int blockIndex, com.sigmob.sdk.downloader.core.breakpoint.a info) {
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.b.InterfaceC0565b
    public final void a(com.sigmob.sdk.downloader.f task, long currentOffset) {
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.b.InterfaceC0565b
    public final void a(com.sigmob.sdk.downloader.f task, com.sigmob.sdk.downloader.core.breakpoint.c info, boolean fromBreakpoint, com.sigmob.sdk.downloader.core.listener.assist.b.c model) {
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.b.InterfaceC0565b
    public final void a(com.sigmob.sdk.downloader.f task, com.sigmob.sdk.downloader.core.cause.a cause, Exception realCause, com.sigmob.sdk.downloader.core.listener.assist.b.c model) {
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.b.InterfaceC0565b
    public final void d(com.sigmob.sdk.downloader.f task, int blockIndex, long currentBlockOffset) {
    }
}
