package com.tencent.turingfd.sdk.ams.ad;

import java.net.URL;
import java.util.HashMap;

/* JADX INFO: loaded from: classes4.dex */
public final class Ginkgo {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final URL f3851a;
    public final HashMap b;
    public int c;
    public int d;
    public final boolean e;

    public Ginkgo(String str) {
        HashMap map = new HashMap();
        this.b = map;
        this.c = 10000;
        this.d = 10000;
        this.e = true;
        this.f3851a = new URL(str);
        map.put("Content-Type", "application/json; charset=utf-8");
    }
}
