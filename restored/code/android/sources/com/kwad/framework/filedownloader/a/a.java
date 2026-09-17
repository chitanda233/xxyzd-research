package com.kwad.framework.filedownloader.a;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements com.kwad.framework.filedownloader.f.c.a {
    @Override // com.kwad.framework.filedownloader.f.c.a
    public final int Y(long j) {
        if (j < 1048576) {
            return 1;
        }
        if (j < 5242880) {
            return 2;
        }
        if (j < 52428800) {
            return 3;
        }
        return j < 104857600 ? 4 : 5;
    }
}
