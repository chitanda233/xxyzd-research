package com.cmic.gen.sdk.f;

import java.text.SimpleDateFormat;
import java.util.Date;

/* JADX INFO: compiled from: TimeUtils.java */
/* JADX INFO: loaded from: classes2.dex */
public class p {
    public static String a() {
        return new SimpleDateFormat("yyyyMMddHHmmssSSS").format(new Date(System.currentTimeMillis()));
    }
}
