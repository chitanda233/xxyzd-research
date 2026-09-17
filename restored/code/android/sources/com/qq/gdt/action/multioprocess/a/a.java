package com.qq.gdt.action.multioprocess.a;

import android.text.TextUtils;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile a f3095a;
    private List<b> b = new ArrayList();

    public static a a() {
        if (f3095a == null) {
            synchronized (a.class) {
                if (f3095a == null) {
                    f3095a = new a();
                    f3095a.a(new c());
                }
            }
        }
        return f3095a;
    }

    private void a(b bVar) {
        this.b.add(bVar);
    }

    public String b() {
        Iterator<b> it = this.b.iterator();
        while (it.hasNext()) {
            String strA = it.next().a();
            if (!TextUtils.isEmpty(strA)) {
                return strA;
            }
        }
        return null;
    }
}
