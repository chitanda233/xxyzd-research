package com.qq.gdt.action.e;

import com.qq.gdt.action.e.b.g;
import com.qq.gdt.action.e.d;
import com.qq.gdt.action.i.i;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public abstract class d<T extends d> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected String f3064a;
    protected Map<String, String> b;
    protected final g.a c = new g.a();

    public T a(String str) {
        this.f3064a = str;
        return this;
    }

    protected void a() {
        this.c.a("User-Agent", i.a("GDTActionSDK-[" + System.getProperty("http.agent") + "]"));
        Map<String, String> map = this.b;
        if (map == null || map.isEmpty()) {
            return;
        }
        for (String str : this.b.keySet()) {
            this.c.a(str, this.b.get(str));
        }
    }
}
