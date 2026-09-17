package com.byazt.pct;

import android.content.Context;
import android.os.Looper;
import android.text.TextUtils;
import java.util.LinkedHashSet;
import java.util.Set;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 124, 72})
public class da {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public boolean f1314a;
    public com.byazt.nl.uj c;
    public yp da;
    public u i;
    public sl.tt m;
    public Context n;
    public Looper nu;
    public boolean sp;
    public c tt;
    public x uj;
    public boolean x;
    public boolean yp;
    public boolean z;
    public String ve = "IESJSBridge";
    public String sl = com.alipay.sdk.m.n.c.f;
    public final Set<String> t = new LinkedHashSet();
    public final Set<String> u = new LinkedHashSet();

    public da(com.byazt.nl.uj ujVar) {
        this.c = ujVar;
    }

    public da() {
    }

    public da c(c cVar) {
        this.tt = cVar;
        return this;
    }

    public da c(String str) {
        this.ve = str;
        return this;
    }

    public da c(t tVar) {
        this.uj = x.c(tVar);
        return this;
    }

    public da c(boolean z) {
        this.f1314a = z;
        return this;
    }

    public da tt(boolean z) {
        this.sp = z;
        return this;
    }

    public da c() {
        this.z = true;
        return this;
    }

    public nu tt() {
        uj();
        return new nu(this);
    }

    public Context getContext() {
        return this.n;
    }

    private void uj() {
        if ((this.c == null && !this.yp && this.tt == null) || ((TextUtils.isEmpty(this.ve) && this.c != null) || this.uj == null)) {
            throw new IllegalArgumentException("Requested arguments aren't set properly when building JsBridge.");
        }
    }

    public Looper ve() {
        return this.nu;
    }
}
