package com.sigmob.sdk.downloader.core.listener;

/* JADX INFO: loaded from: classes3.dex */
public abstract class c extends a {

    /* JADX INFO: renamed from: com.sigmob.sdk.downloader.core.listener.c$1, reason: invalid class name */
    static /* synthetic */ class AnonymousClass1 {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f3450a;

        static {
            int[] iArr = new int[com.sigmob.sdk.downloader.core.cause.a.values().length];
            f3450a = iArr;
            try {
                iArr[com.sigmob.sdk.downloader.core.cause.a.COMPLETED.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                f3450a[com.sigmob.sdk.downloader.core.cause.a.CANCELED.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                f3450a[com.sigmob.sdk.downloader.core.cause.a.ERROR.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            try {
                f3450a[com.sigmob.sdk.downloader.core.cause.a.PRE_ALLOCATE_FAILED.ordinal()] = 4;
            } catch (NoSuchFieldError unused4) {
            }
            try {
                f3450a[com.sigmob.sdk.downloader.core.cause.a.FILE_BUSY.ordinal()] = 5;
            } catch (NoSuchFieldError unused5) {
            }
            try {
                f3450a[com.sigmob.sdk.downloader.core.cause.a.SAME_TASK_BUSY.ordinal()] = 6;
            } catch (NoSuchFieldError unused6) {
            }
        }
    }

    protected abstract void a(com.sigmob.sdk.downloader.f task);

    @Override // com.sigmob.sdk.downloader.core.listener.assist.a.InterfaceC0564a
    public void a(com.sigmob.sdk.downloader.f task, com.sigmob.sdk.downloader.core.cause.a cause, Exception realCause, com.sigmob.sdk.downloader.core.listener.assist.a.b model) {
        switch (AnonymousClass1.f3450a[cause.ordinal()]) {
            case 1:
                a(task);
                break;
            case 2:
                c(task);
                break;
            case 3:
            case 4:
                a(task, realCause);
                break;
            case 5:
            case 6:
                d(task);
                break;
            default:
                com.sigmob.sdk.downloader.core.c.a("DownloadListener3", "Don't support " + cause);
                break;
        }
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.a.InterfaceC0564a
    public final void a(com.sigmob.sdk.downloader.f task, com.sigmob.sdk.downloader.core.listener.assist.a.b model) {
        b(task);
    }

    protected abstract void a(com.sigmob.sdk.downloader.f task, Exception e);

    protected abstract void b(com.sigmob.sdk.downloader.f task);

    protected abstract void c(com.sigmob.sdk.downloader.f task);

    protected abstract void d(com.sigmob.sdk.downloader.f task);
}
