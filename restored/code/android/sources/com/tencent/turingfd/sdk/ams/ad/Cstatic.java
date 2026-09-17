package com.tencent.turingfd.sdk.ams.ad;

import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import android.text.TextUtils;
import java.util.ArrayList;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.static, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public final class Cstatic extends Handler {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Grapefruit f3961a;
    public final ArrayList b;

    public Cstatic(Looper looper, Grapefruit grapefruit) {
        super(looper);
        this.b = new ArrayList();
        this.f3961a = grapefruit;
    }

    public final void a() {
        ArrayList arrayList = this.b;
        int size = arrayList.size();
        int i = 0;
        while (i < size) {
            Object obj = arrayList.get(i);
            i++;
            Bilberry bilberry = (Bilberry) obj;
            bilberry.getClass();
            synchronized (Bilberry.j) {
                int i2 = Bilberry.k;
                if (i2 < 200) {
                    Bilberry.k = i2 + 1;
                    bilberry.f3825a = Bilberry.l;
                    bilberry.i = 0;
                    Bilberry.l = bilberry;
                }
            }
        }
        this.b.clear();
    }

    @Override // android.os.Handler
    public final void handleMessage(Message message) {
        int i = message.what;
        a aVar = null;
        if (i == 1) {
            Object obj = message.obj;
            if (obj instanceof String) {
                Grapefruit grapefruit = this.f3961a;
                Cswitch cswitch = new Cswitch((String) obj, 3, null);
                grapefruit.getClass();
                Grapefruit.a(cswitch);
                return;
            }
            return;
        }
        if (i != 2) {
            return;
        }
        Object obj2 = message.obj;
        if (obj2 instanceof Bilberry) {
            Bilberry bilberry = (Bilberry) obj2;
            String str = bilberry.b;
            if (TextUtils.isEmpty(str)) {
                return;
            }
            if (!this.b.isEmpty() && !((Bilberry) this.b.get(0)).b.equals(bilberry.b)) {
                a();
            }
            int i2 = bilberry.c;
            if (i2 == 0) {
                a();
                this.b.add(bilberry);
                return;
            }
            if (i2 != 1) {
                if (i2 == 2) {
                    this.b.isEmpty();
                    this.b.add(bilberry);
                    return;
                } else {
                    if (i2 != 3) {
                        return;
                    }
                    a();
                    return;
                }
            }
            if (this.b.isEmpty()) {
                return;
            }
            this.b.add(bilberry);
            ArrayList arrayList = this.b;
            ArrayList arrayList2 = new ArrayList();
            if (arrayList.size() <= 8) {
                arrayList2.addAll(arrayList);
            } else {
                Bilberry bilberry2 = (Bilberry) arrayList.get(0);
                Bilberry bilberry3 = (Bilberry) arrayList.get(arrayList.size() - 1);
                arrayList.remove(bilberry2);
                arrayList.remove(bilberry3);
                int iCeil = (int) Math.ceil(arrayList.size() / 6);
                arrayList2.add(bilberry2);
                for (int i3 = 1; i3 < arrayList.size(); i3 += iCeil) {
                    arrayList2.add(arrayList.get(i3));
                }
                arrayList2.add(bilberry3);
            }
            if (!arrayList2.isEmpty()) {
                Bilberry bilberry4 = (Bilberry) arrayList2.get(0);
                a aVar2 = new a();
                long jCurrentTimeMillis = System.currentTimeMillis();
                long j = bilberry4.h;
                aVar2.b = (int) (jCurrentTimeMillis - j);
                aVar2.f3909a = j;
                ArrayList arrayList3 = new ArrayList();
                int size = arrayList2.size();
                int i4 = 0;
                while (i4 < size) {
                    Object obj3 = arrayList2.get(i4);
                    i4++;
                    Bilberry bilberry5 = (Bilberry) obj3;
                    b bVar = new b();
                    int i5 = bilberry5.c;
                    if (i5 == 0) {
                        bVar.f3912a = 1;
                    } else if (i5 == 1) {
                        bVar.f3912a = 3;
                    } else if (i5 == 2) {
                        bVar.f3912a = 2;
                    } else if (i5 != 3) {
                        bVar.f3912a = 0;
                    } else {
                        bVar.f3912a = 4;
                    }
                    bVar.d = bilberry5.f;
                    bVar.e = bilberry5.g;
                    arrayList3.add(bVar);
                }
                aVar2.c = arrayList3;
                aVar = aVar2;
            }
            if (aVar == null) {
                return;
            }
            if (bilberry.d <= 0) {
                aVar.d |= 1;
            }
            if (bilberry.e == 0) {
                aVar.d |= 2;
            }
            if ((bilberry.i & (-1073741824)) == -1073741824) {
                aVar.d |= 4;
            }
            if (aVar.d != 0) {
                Grapefruit grapefruit2 = this.f3961a;
                Cswitch cswitch2 = new Cswitch(str, 2, aVar);
                grapefruit2.getClass();
                Grapefruit.a(cswitch2);
            } else {
                Grapefruit grapefruit3 = this.f3961a;
                Cswitch cswitch3 = new Cswitch(str, 1, aVar);
                grapefruit3.getClass();
                Grapefruit.a(cswitch3);
            }
            a();
        }
    }
}
