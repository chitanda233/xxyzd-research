package com.byazt.na;

import android.support.v4.media.session.PlaybackStateCompat;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 662, 91})
public final class sp {
    public static a c;
    public static long tt;

    private sp() {
    }

    public static a c() {
        synchronized (sp.class) {
            a aVar = c;
            if (aVar != null) {
                c = aVar.f1184a;
                aVar.f1184a = null;
                tt -= PlaybackStateCompat.ACTION_PLAY_FROM_URI;
                return aVar;
            }
            return new a();
        }
    }

    public static void c(a aVar) {
        if (aVar.f1184a != null || aVar.sp != null) {
            throw new IllegalArgumentException();
        }
        if (aVar.uj) {
            return;
        }
        synchronized (sp.class) {
            long j = tt;
            if (j + PlaybackStateCompat.ACTION_PLAY_FROM_URI > PlaybackStateCompat.ACTION_PREPARE_FROM_SEARCH) {
                return;
            }
            tt = j + PlaybackStateCompat.ACTION_PLAY_FROM_URI;
            aVar.f1184a = c;
            aVar.ve = 0;
            aVar.tt = 0;
            c = aVar;
        }
    }
}
