package com.kwad.sdk.crash.utils;

import java.text.SimpleDateFormat;
import java.util.Date;

/* JADX INFO: loaded from: classes3.dex */
public final class i {
    private static SimpleDateFormat bgs = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");

    public static String aQ(long j) {
        return j <= 0 ? "unknown" : bgs.format(new Date(j));
    }
}
