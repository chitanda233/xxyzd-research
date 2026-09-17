package com.qq.gdt.action;

import android.content.Context;
import android.os.Handler;
import android.os.HandlerThread;
import android.os.Looper;
import android.os.Message;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.qq.gdt.action.i.n;
import com.qq.gdt.action.i.o;
import com.qq.gdt.action.i.p;
import com.qq.gdt.action.i.t;
import com.qq.gdt.action.i.v;
import com.qq.gdt.action.i.w;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.Set;
import java.util.concurrent.ConcurrentHashMap;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile a f3011a;
    private final Context b;
    private final C0548a c = new C0548a();

    /* JADX INFO: renamed from: com.qq.gdt.action.a$a, reason: collision with other inner class name */
    private class C0548a {
        private final Object b = new Object();
        private Handler c;

        /* JADX INFO: renamed from: com.qq.gdt.action.a$a$a, reason: collision with other inner class name */
        private class HandlerC0549a extends Handler {
            private final Set<Long> b;
            private boolean c;
            private final Map<String, com.qq.gdt.action.b.a> d;
            private final Set<String> e;
            private final com.qq.gdt.action.b.b f;
            private boolean g;

            HandlerC0549a(Looper looper) {
                super(looper);
                this.b = Collections.newSetFromMap(new ConcurrentHashMap());
                this.c = false;
                this.d = new ConcurrentHashMap();
                this.e = Collections.newSetFromMap(new ConcurrentHashMap());
                this.g = false;
                this.f = com.qq.gdt.action.b.b.a(a.this.b);
            }

            private void a() throws Throwable {
                o.a("======>Action reporter running now.", new Object[0]);
                this.g = true;
                b();
                c();
            }

            private void a(int i) throws Throwable {
                if (!p.a(a.this.b)) {
                    o.a(v.a("Network not available while flush actions(status=%d), schedule later.", Integer.valueOf(i)), new Object[0]);
                    return;
                }
                long jMax = 0;
                while (true) {
                    List<com.qq.gdt.action.b.a> listA = this.f.a(i, 50L, jMax);
                    if (com.qq.gdt.action.i.f.a(listA)) {
                        o.a(v.a("No more actions in status(%d), bravo!", Integer.valueOf(i)), new Object[0]);
                        return;
                    }
                    Iterator<com.qq.gdt.action.b.a> it = listA.iterator();
                    while (it.hasNext()) {
                        com.qq.gdt.action.b.a next = it.next();
                        jMax = Math.max(jMax, next.f());
                        if (!this.b.contains(Long.valueOf(next.f()))) {
                            if (next.c().equals(ActionType.START_APP) || next.c().equals("TENCENT_INNER_START_APP")) {
                                if (!this.c) {
                                    this.c = true;
                                }
                            }
                        }
                        it.remove();
                    }
                    if (!com.qq.gdt.action.i.f.a(listA)) {
                        Iterator<com.qq.gdt.action.b.a> it2 = listA.iterator();
                        while (it2.hasNext()) {
                            this.b.add(Long.valueOf(it2.next().f()));
                        }
                        o.a(v.a("Flushing %d actions(status=%d)", Integer.valueOf(listA.size()), Integer.valueOf(i)), new Object[0]);
                        a(listA, i);
                    }
                }
            }

            private void a(Message message) {
                List<com.qq.gdt.action.b.a> list = (List) message.obj;
                if (this.f.a(list)) {
                    if (!b(list) && this.f.a(0) < 5) {
                        return;
                    }
                } else if (!a(list)) {
                    return;
                }
                c();
            }

            /* JADX INFO: Access modifiers changed from: private */
            public void a(com.qq.gdt.action.b.a aVar, boolean z) {
                if (aVar == null) {
                    return;
                }
                long jD = aVar.d();
                long jH = aVar.h();
                if (jH <= 0 && w.a()) {
                    jH = w.b();
                }
                if (ActionType.START_APP.equals(aVar.c()) || "TENCENT_INNER_START_APP".equals(aVar.c())) {
                    this.c = false;
                    t.a(a.this.b, jD, jH);
                }
            }

            private void a(List<com.qq.gdt.action.b.a> list, final int i) {
                com.qq.gdt.action.h.c.a(list, new com.qq.gdt.action.h.c.a() { // from class: com.qq.gdt.action.a.a.a.1
                    @Override // com.qq.gdt.action.h.c.a
                    public void a(List<com.qq.gdt.action.b.a> list2, int i2, String str, int i3, String str2) {
                        if (com.qq.gdt.action.i.f.b(list2)) {
                            ArrayList arrayList = new ArrayList();
                            for (com.qq.gdt.action.b.a aVar : list2) {
                                JSONObject jSONObject = new JSONObject();
                                try {
                                    jSONObject.putOpt("httpStatus", Integer.valueOf(i3));
                                    jSONObject.putOpt(MediationConstant.KEY_ERROR_CODE, Integer.valueOf(i2));
                                    jSONObject.putOpt(MediationConstant.KEY_ERROR_MSG, str);
                                    jSONObject.putOpt("requestCgi", Integer.valueOf(i3));
                                    jSONObject.putOpt("traceId", str2);
                                } catch (JSONException e) {
                                    e.printStackTrace();
                                }
                                if (aVar.f() > 0) {
                                    arrayList.add(aVar);
                                } else {
                                    HandlerC0549a.this.e.remove(aVar.a());
                                }
                                if (i3 != 200 || i2 <= 0) {
                                    o.b(v.a("LogAction failed(scheduled retry %d milliseconds later): actionType = %s , actionParams = %s, userActionSetId = %s", Integer.valueOf(b.a(a.this.b).b()), aVar.c(), aVar.e(), d.a().h()));
                                } else {
                                    o.c(v.a("LogAction failed(errorCode = %d, errorMessage = %s, traceId = %s): actionType = %s , actionParams = %s, userActionSetId = %s", Integer.valueOf(i2), str, str2, aVar.c(), aVar.e(), d.a().h()));
                                }
                                if (ActionType.START_APP.equals(aVar.c())) {
                                    HandlerC0549a.this.c = false;
                                }
                            }
                            if (com.qq.gdt.action.i.f.b(arrayList)) {
                                if (i3 == 200 && i2 > 0) {
                                    HandlerC0549a.this.b(arrayList, 4);
                                } else if (i != 2) {
                                    HandlerC0549a.this.b(arrayList, 2);
                                }
                                Iterator it = arrayList.iterator();
                                while (it.hasNext()) {
                                    HandlerC0549a.this.b.remove(Long.valueOf(((com.qq.gdt.action.b.a) it.next()).f()));
                                }
                                o.b(v.a("Flush actions(status=%d) failed(http status = %d): code = %d, msg = %s", Integer.valueOf(i), Integer.valueOf(i3), Integer.valueOf(i2), str));
                            }
                        }
                    }

                    @Override // com.qq.gdt.action.h.c.a
                    public void a(List<com.qq.gdt.action.b.a> list2, boolean z) {
                        if (com.qq.gdt.action.i.f.b(list2)) {
                            ArrayList arrayList = new ArrayList();
                            for (com.qq.gdt.action.b.a aVar : list2) {
                                if (aVar.f() > 0) {
                                    arrayList.add(aVar);
                                } else {
                                    HandlerC0549a.this.d.remove(aVar.a());
                                    HandlerC0549a.this.e.remove(aVar.a());
                                }
                                HandlerC0549a.this.a(aVar, z);
                                if (GDTAction.isAutoCollectionAction(aVar)) {
                                    o.a(v.a("LogAction success: actionType = %s, actionParams = %s, userActionSetId = %s", aVar.c(), aVar.e(), d.a().h()), new Object[0]);
                                } else {
                                    o.a(v.a("LogAction success: actionType = %s, actionParams = %s, userActionSetId = %s", aVar.c(), aVar.e(), d.a().h()));
                                }
                            }
                            if (arrayList.isEmpty()) {
                                return;
                            }
                            HandlerC0549a.this.b(arrayList, 1);
                            Iterator it = arrayList.iterator();
                            while (it.hasNext()) {
                                HandlerC0549a.this.b.remove(Long.valueOf(((com.qq.gdt.action.b.a) it.next()).f()));
                            }
                            o.a(v.a("Flushed %d Actions in status(%d)", Integer.valueOf(list2.size()), Integer.valueOf(i)), new Object[0]);
                        }
                    }
                });
            }

            private boolean a(List<com.qq.gdt.action.b.a> list) {
                boolean z = false;
                for (com.qq.gdt.action.b.a aVar : list) {
                    if (b.a(a.this.b).a(aVar.c())) {
                        this.d.put(aVar.a(), aVar);
                        z = true;
                    }
                }
                return z;
            }

            private void b() throws Throwable {
                o.a("Cleaning old actions.", new Object[0]);
                this.f.a();
            }

            /* JADX INFO: Access modifiers changed from: private */
            public void b(List<com.qq.gdt.action.b.a> list, int i) {
                if (com.qq.gdt.action.i.f.a(list)) {
                    return;
                }
                int iA = this.f.a(list, i);
                for (com.qq.gdt.action.b.a aVar : list) {
                    if (iA < 0) {
                        com.qq.gdt.action.g.a.a(AVMDLDataLoader.KeyIsStoRingBufferSizeKB, aVar, n.a("dbStatus", i));
                    }
                }
                if (iA < 0) {
                    o.c("Update action status error");
                }
            }

            private boolean b(List<com.qq.gdt.action.b.a> list) {
                Iterator<com.qq.gdt.action.b.a> it = list.iterator();
                while (it.hasNext()) {
                    if (b.a(a.this.b).a(it.next().c())) {
                        return true;
                    }
                }
                return false;
            }

            private void c() {
                if (this.g) {
                    o.a("Flush all actions.", new Object[0]);
                    try {
                        e();
                        f();
                    } catch (Throwable unused) {
                    }
                    d();
                }
            }

            private void d() {
                ArrayList arrayList = new ArrayList();
                ArrayList arrayList2 = new ArrayList();
                for (com.qq.gdt.action.b.a aVar : this.d.values()) {
                    if (!this.e.contains(aVar.a())) {
                        if (ActionType.START_APP.equals(aVar.c()) || "TENCENT_INNER_START_APP".equals(aVar.c())) {
                            if (!this.c) {
                                this.c = true;
                            }
                        }
                        arrayList.add(aVar);
                        this.e.add(aVar.a());
                    }
                }
                Iterator it = arrayList2.iterator();
                while (it.hasNext()) {
                    this.d.remove((String) it.next());
                }
                if (arrayList.isEmpty()) {
                    return;
                }
                if (arrayList.size() <= 50) {
                    a(arrayList, -1);
                    return;
                }
                Iterator it2 = com.qq.gdt.action.i.f.a(arrayList, 50).iterator();
                while (it2.hasNext()) {
                    a((List<com.qq.gdt.action.b.a>) it2.next(), -1);
                }
            }

            private void e() throws Throwable {
                o.a("Flush all pending actions.", new Object[0]);
                a(0);
            }

            private void f() throws Throwable {
                o.a("Flush all failed actions.", new Object[0]);
                a(2);
            }

            @Override // android.os.Handler
            public void handleMessage(Message message) {
                try {
                    o.a("Handle message: " + message.what, new Object[0]);
                    int i = message.what;
                    if (i == 1) {
                        c();
                    } else if (i == 5) {
                        a();
                    } else if (i != 6) {
                        o.a("Unexpected message received by reporter: " + message);
                    } else {
                        a(message);
                    }
                } catch (Throwable th) {
                    o.a("Worker handle message threw an unhandled exception", th);
                }
                try {
                    if (hasMessages(1)) {
                        return;
                    }
                    Message messageObtain = Message.obtain();
                    messageObtain.what = 1;
                    sendMessageDelayed(messageObtain, b.a(a.this.b).b());
                } catch (Throwable th2) {
                    o.b("Send Delay 'FLUSH_ACTION' message failed", th2);
                }
            }
        }

        C0548a() {
            HandlerThread handlerThread = new HandlerThread("com.qq.gdt.action.ActionReporter.Worker", 10);
            handlerThread.start();
            this.c = new HandlerC0549a(handlerThread.getLooper());
        }

        void a(Message message) {
            synchronized (this.b) {
                Handler handler = this.c;
                if (handler == null) {
                    o.c("Dropping a message: " + message.what);
                } else {
                    handler.sendMessage(message);
                }
            }
        }
    }

    private a(Context context) {
        this.b = context;
    }

    public static a a(Context context) {
        if (f3011a == null) {
            synchronized (a.class) {
                if (f3011a == null) {
                    f3011a = new a(context);
                }
            }
        }
        return f3011a;
    }

    public void a() {
        Message messageObtain = Message.obtain();
        messageObtain.what = 1;
        this.c.a(messageObtain);
    }

    public void a(com.qq.gdt.action.b.a... aVarArr) {
        Message messageObtain = Message.obtain();
        messageObtain.what = 6;
        messageObtain.obj = Arrays.asList(aVarArr);
        this.c.a(messageObtain);
    }

    public void b() {
        Message messageObtain = Message.obtain();
        messageObtain.what = 5;
        this.c.a(messageObtain);
    }
}
