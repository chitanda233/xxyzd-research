package com.qq.gdt.action.multioprocess;

import android.content.ContentResolver;
import android.content.Context;
import android.net.Uri;
import android.os.Bundle;
import com.qq.gdt.action.i.g;
import com.qq.gdt.action.i.h;
import com.qq.gdt.action.i.j;
import com.qq.gdt.action.i.o;
import com.qq.gdt.action.i.s;

/* JADX INFO: loaded from: classes3.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile a f3093a;

    public static a a() {
        if (f3093a == null) {
            synchronized (a.class) {
                if (f3093a == null) {
                    f3093a = new a();
                }
            }
        }
        return f3093a;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public b a(Context context, String str) {
        return a(context, str, (b) null);
    }

    private b a(Context context, String str, b bVar) {
        try {
            str.equals("save_user_info");
            if (context == null) {
                context = com.qq.gdt.action.d.a().g();
            }
            if (context == null) {
                return null;
            }
            ContentResolver contentResolver = context.getApplicationContext().getContentResolver();
            Uri uri = Uri.parse("content://" + h.a() + ".GDTInitProvider");
            Bundle bundle = new Bundle();
            if (str.equals("save_user_info") && bVar != null) {
                bundle.putSerializable("user_message_info", bVar);
            }
            return (b) contentResolver.call(uri, str, (String) null, bundle).getSerializable("result_user_info");
        } catch (Throwable th) {
            o.a("sendMsg e", th);
            return null;
        }
    }

    public void a(b bVar) {
        if (c()) {
            try {
                if (g.a().b()) {
                    d.a().f3099a = bVar;
                    s.a(bVar);
                } else {
                    a(com.qq.gdt.action.d.a().g(), "save_user_info", bVar);
                }
            } catch (Throwable th) {
                o.a("client process saveMessage t = " + th, new Object[0]);
            }
        }
    }

    public void a(final c cVar) {
        j.a().b().execute(new Runnable() { // from class: com.qq.gdt.action.multioprocess.a.1
            @Override // java.lang.Runnable
            public void run() {
                b bVarA;
                c cVar2;
                try {
                    if (!a.this.c()) {
                        cVar.a(null);
                        return;
                    }
                    if (g.a().b()) {
                        bVarA = d.a().f3099a;
                        if (bVarA == null) {
                            s.a(cVar);
                            return;
                        }
                        cVar2 = cVar;
                    } else {
                        Context contextG = com.qq.gdt.action.d.a().g();
                        if (!com.qq.gdt.action.d.a().y()) {
                            cVar.a(null);
                            return;
                        }
                        o.a("client process time allow , try get info", new Object[0]);
                        com.qq.gdt.action.d.a().f3026a = System.currentTimeMillis();
                        bVarA = a.this.a(contextG, "get_user_info");
                        cVar2 = cVar;
                    }
                    cVar2.a(bVarA);
                } catch (Throwable th) {
                    o.a("getMessageAsync Throwable t = " + th, new Object[0]);
                    cVar.a(null);
                }
            }
        });
    }

    public b b() {
        try {
            if (!c()) {
                return null;
            }
            if (!g.a().b()) {
                return a(com.qq.gdt.action.d.a().g(), "get_user_info");
            }
            if (d.a().f3099a == null) {
                return s.a();
            }
            return null;
        } catch (Throwable th) {
            o.a("getMessageAsync Throwable t = " + th, new Object[0]);
            return null;
        }
    }

    public boolean c() {
        boolean z = true;
        try {
            if (com.qq.gdt.action.b.a(com.qq.gdt.action.d.a().g()).q() != 0) {
                z = false;
            }
        } catch (Throwable th) {
            o.a("fillUserInfo e = " + th, new Object[0]);
        }
        o.a("fillUserInfo " + z, new Object[0]);
        return z;
    }
}
