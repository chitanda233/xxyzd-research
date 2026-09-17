package com.sigmob.sdk.videocache;

/* JADX INFO: loaded from: classes4.dex */
public class s {
    public static t a(t source) {
        l lVar;
        if (com.sigmob.sdk.base.o.a().Z()) {
            try {
                lVar = new l(source);
            } catch (Throwable unused) {
                lVar = null;
            }
        } else {
            lVar = null;
        }
        return lVar == null ? new i(source) : lVar;
    }

    public static t a(String url) {
        l lVar;
        if (com.sigmob.sdk.base.o.a().Z()) {
            try {
                lVar = new l(url);
            } catch (Throwable unused) {
                lVar = null;
            }
        } else {
            lVar = null;
        }
        return lVar == null ? new i(url) : lVar;
    }

    public static t a(String url, com.sigmob.sdk.videocache.sourcestorage.c sourceInfoStorage, com.sigmob.sdk.videocache.headers.b headerInjector) {
        l lVar;
        if (com.sigmob.sdk.base.o.a().Z()) {
            try {
                lVar = new l(url, sourceInfoStorage, headerInjector);
            } catch (Throwable unused) {
                lVar = null;
            }
        } else {
            lVar = null;
        }
        return lVar == null ? new i(url, sourceInfoStorage, headerInjector) : lVar;
    }
}
