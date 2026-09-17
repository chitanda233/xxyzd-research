package com.byazt.dc;

import android.util.SparseArray;
import com.kuaishou.weapon.p0.t;
import java.util.function.Function;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 2063, 54})
public class ve implements com.byazt.xiv.ve {
    public String c;
    public Function<SparseArray<Object>, Object> tt;
    public String ve;

    public ve(String str) {
        this.c = str;
    }

    @Override // com.byazt.xiv.ve
    public Function<SparseArray<Object>, Object> getInitBridge() {
        return n.tt(this.c);
    }

    @Override // com.byazt.xiv.ve
    public String getClassName() {
        return c() + "_class_name";
    }

    @Override // com.byazt.xiv.ve
    public String getAdnVersionListKey() {
        return c() + "_adn_version";
    }

    @Override // com.byazt.xiv.ve
    public String getAdnVersion() {
        String str = this.c;
        str.hashCode();
        switch (str) {
            case "xiaomi":
                return com.byazt.xiv.n.x();
            case "ks":
                return com.byazt.xiv.n.a();
            case "gdt":
                return com.byazt.xiv.n.sp();
            default:
                return null;
        }
    }

    @Override // com.byazt.xiv.ve
    public void saveManager(Function<SparseArray<Object>, Object> function) {
        this.tt = function;
    }

    @Override // com.byazt.xiv.ve
    public Function<SparseArray<Object>, Object> getManager() {
        return this.tt;
    }

    @Override // com.byazt.xiv.ve
    public void saveUnSupportVersion(String str) {
        this.ve = str;
    }

    @Override // com.byazt.xiv.ve
    public String getUnSupportVersion() {
        return this.ve;
    }

    @Override // com.byazt.xiv.ve
    public String getAdnName() {
        return this.c;
    }

    private String c() {
        String str = this.c;
        str.hashCode();
        switch (str) {
            case "sigmob":
                return t.g;
            case "xiaomi":
                return "x";
            case "ks":
                return t.f2732a;
            case "gdt":
                return "g";
            case "baidu":
                return t.l;
            case "unity":
                return "u";
            default:
                return null;
        }
    }
}
