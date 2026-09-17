package com.qq.gdt.action.multioprocess.b;

import com.qq.gdt.action.i.o;
import java.io.Serializable;

/* JADX INFO: loaded from: classes3.dex */
public abstract class b implements Serializable {
    private String b;
    private int d;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f3098a = getClass().getSimpleName();
    private int c = 0;

    public static class a extends b {
    }

    /* JADX INFO: renamed from: com.qq.gdt.action.multioprocess.b.b$b, reason: collision with other inner class name */
    public static class C0552b extends b {
    }

    public static class c extends b {
    }

    public static class d extends b {
    }

    public static class e extends b {
    }

    public static class f extends b {
    }

    public static class g extends b {
    }

    public static class h extends b {
    }

    public static class i extends b {
    }

    public static class j extends b {
    }

    public static class k extends b {
    }

    public static class l extends b {
    }

    public static class m extends b {
    }

    public b() {
        this.d = 1;
        try {
            this.d = com.qq.gdt.action.b.a(com.qq.gdt.action.d.a().g()).p();
        } catch (Throwable th) {
            o.a("DeviceInfoItem fetchLimit e = " + th, new Object[0]);
        }
    }

    public String a() {
        return this.b;
    }

    public void a(String str) {
        this.b = str;
    }

    public int b() {
        return this.c;
    }

    public int c() {
        return this.d;
    }

    public void d() {
        this.c++;
    }

    public String toString() {
        StringBuilder sb = new StringBuilder("{\"type\":\"");
        sb.append(this.f3098a).append("\",\"deviceValue\":\"");
        sb.append(this.b).append("\",\"fetchTimes\":");
        sb.append(this.c);
        sb.append(",\"limitTimes\":").append(this.d);
        sb.append('}');
        return sb.toString();
    }
}
