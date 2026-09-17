package com.byazt.uy;

import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 1180, 13})
public class tt {
    public Map<ve, List<c>> c = new HashMap();
    public Map<String, String> tt = new HashMap();
    public final List<Object> ve = new CopyOnWriteArrayList();
    public final List<Object> uj = new CopyOnWriteArrayList();
    public final List<Object> n = new CopyOnWriteArrayList();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final List<Object> f1499a = new CopyOnWriteArrayList();
    public a sp = null;

    public List<c> c(ve veVar) {
        return this.c.get(veVar);
    }

    public void c(Map<? extends String, ? extends String> map) {
        this.tt.putAll(map);
    }

    public Map<String, String> c() {
        return this.tt;
    }

    public List<Object> tt() {
        return this.uj;
    }

    public List<Object> ve() {
        return this.f1499a;
    }

    public void c(a aVar) {
        this.sp = aVar;
    }

    public a uj() {
        return this.sp;
    }
}
