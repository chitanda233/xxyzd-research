package com.qq.gdt.action.f;

import android.os.HandlerThread;
import android.os.Message;
import java.util.ArrayList;

/* JADX INFO: loaded from: classes3.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile b f3070a;
    private final a b;

    private b() {
        HandlerThread handlerThread = new HandlerThread("recorder");
        handlerThread.start();
        this.b = new a(handlerThread.getLooper());
    }

    public static b a() {
        if (f3070a == null) {
            synchronized (b.class) {
                if (f3070a == null) {
                    f3070a = new b();
                }
            }
        }
        return f3070a;
    }

    public void a(com.qq.gdt.action.f.a.a... aVarArr) {
        ArrayList arrayList = new ArrayList();
        for (com.qq.gdt.action.f.a.a aVar : aVarArr) {
            if (aVar != null) {
                arrayList.add(aVar);
            }
        }
        Message messageObtainMessage = this.b.obtainMessage(2);
        messageObtainMessage.obj = arrayList;
        this.b.sendMessage(messageObtainMessage);
    }

    void b() {
        this.b.sendEmptyMessage(3);
    }
}
