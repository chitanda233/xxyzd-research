package com.tencent.bugly.proguard;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import com.tencent.bugly.crashreport.biz.UserInfoBean;
import com.tencent.bugly.crashreport.common.strategy.StrategyBean;
import java.io.BufferedReader;
import java.io.File;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

/* JADX INFO: compiled from: BUGLY */
/* JADX INFO: loaded from: classes4.dex */
public final class r {
    private static boolean e = true;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f3800a;
    private long b;
    private int c;
    private boolean d;

    public r(Context context, boolean z) {
        this.f3800a = context;
        this.d = z;
    }

    public final void a(int i, boolean z) {
        ac acVarA = ac.a();
        if (acVarA != null && !acVarA.c().g && i != 1 && i != 3) {
            al.e("UserInfo is disable", new Object[0]);
            return;
        }
        if (i == 1 || i == 3) {
            this.c++;
        }
        aa aaVarA = aa.a(this.f3800a);
        UserInfoBean userInfoBean = new UserInfoBean();
        userInfoBean.b = i;
        userInfoBean.c = aaVarA.d;
        userInfoBean.d = aaVarA.f();
        userInfoBean.e = System.currentTimeMillis();
        userInfoBean.f = -1L;
        userInfoBean.n = aaVarA.o;
        userInfoBean.o = i == 1 ? 1 : 0;
        userInfoBean.l = aaVarA.a();
        userInfoBean.m = aaVarA.y;
        userInfoBean.g = aaVarA.z;
        userInfoBean.h = aaVarA.A;
        userInfoBean.i = aaVarA.B;
        userInfoBean.k = aaVarA.C;
        userInfoBean.r = aaVarA.t();
        userInfoBean.s = aaVarA.y();
        userInfoBean.p = aaVarA.z();
        userInfoBean.q = aaVarA.x;
        ak.a().a(new a(userInfoBean, z), 0L);
    }

    public final void a(long j) {
        ak.a().a(new c(j), j);
    }

    public final void a() {
        this.b = ap.b() + 86400000;
        ak.a().a(new b(), (this.b - System.currentTimeMillis()) + 5000);
    }

    /* JADX INFO: compiled from: BUGLY */
    class a implements Runnable {
        private boolean b;
        private UserInfoBean c;

        public a(UserInfoBean userInfoBean, boolean z) {
            this.c = userInfoBean;
            this.b = z;
        }

        @Override // java.lang.Runnable
        public final void run() {
            if (r.this.d) {
                try {
                    UserInfoBean userInfoBean = this.c;
                    if (userInfoBean != null) {
                        r.a(userInfoBean);
                        al.c("[UserInfo] Record user info.", new Object[0]);
                        r.this.a(this.c, false);
                    }
                    if (this.b) {
                        r.this.b();
                    }
                } catch (Throwable th) {
                    if (al.a(th)) {
                        return;
                    }
                    th.printStackTrace();
                }
            }
        }
    }

    private static void a(List<UserInfoBean> list, List<UserInfoBean> list2) {
        int size = list.size() - 20;
        if (size > 0) {
            int i = 0;
            while (i < list.size() - 1) {
                int i2 = i + 1;
                for (int i3 = i2; i3 < list.size(); i3++) {
                    if (list.get(i).e > list.get(i3).e) {
                        UserInfoBean userInfoBean = list.get(i);
                        list.set(i, list.get(i3));
                        list.set(i3, userInfoBean);
                    }
                }
                i = i2;
            }
            for (int i4 = 0; i4 < size; i4++) {
                list2.add(list.get(i4));
            }
        }
    }

    private static void b(List<UserInfoBean> list, List<UserInfoBean> list2) {
        Iterator<UserInfoBean> it = list.iterator();
        while (it.hasNext()) {
            UserInfoBean next = it.next();
            if (next.f != -1) {
                it.remove();
                if (next.e < ap.b()) {
                    list2.add(next);
                }
            }
        }
    }

    private static int a(List<UserInfoBean> list) {
        long jCurrentTimeMillis = System.currentTimeMillis();
        int i = 0;
        for (UserInfoBean userInfoBean : list) {
            if (userInfoBean.e > jCurrentTimeMillis - 600000 && (userInfoBean.b == 1 || userInfoBean.b == 4 || userInfoBean.b == 3)) {
                i++;
            }
        }
        return i;
    }

    private void a(final List<UserInfoBean> list, boolean z) {
        aa aaVarB;
        if (!b(z)) {
            long jCurrentTimeMillis = System.currentTimeMillis();
            for (UserInfoBean userInfoBean : list) {
                userInfoBean.f = jCurrentTimeMillis;
                a(userInfoBean, true);
            }
            al.d("uploadCheck failed", new Object[0]);
            return;
        }
        int i = this.c == 1 ? 1 : 2;
        bv bvVar = null;
        if (list != null && list.size() != 0 && (aaVarB = aa.b()) != null) {
            aaVarB.o();
            bv bvVar2 = new bv();
            bvVar2.b = aaVarB.d;
            bvVar2.c = aaVarB.g();
            ArrayList<bu> arrayList = new ArrayList<>();
            Iterator<UserInfoBean> it = list.iterator();
            while (it.hasNext()) {
                bu buVarA = ae.a(it.next());
                if (buVarA != null) {
                    arrayList.add(buVarA);
                }
            }
            bvVar2.d = arrayList;
            bvVar2.e = new HashMap();
            Map<String, String> map = bvVar2.e;
            aaVarB.getClass();
            map.put("A7", "");
            bvVar2.e.put("A6", aa.n());
            bvVar2.e.put("A5", aaVarB.m());
            bvVar2.e.put("A2", new StringBuilder().append(aaVarB.k()).toString());
            bvVar2.e.put("A1", new StringBuilder().append(aaVarB.k()).toString());
            bvVar2.e.put("A24", aaVarB.k);
            bvVar2.e.put("A17", new StringBuilder().append(aaVarB.l()).toString());
            bvVar2.e.put("A15", aaVarB.q());
            bvVar2.e.put("A13", new StringBuilder().append(aaVarB.r()).toString());
            bvVar2.e.put("F08", aaVarB.E);
            bvVar2.e.put("F09", aaVarB.F);
            Map<String, String> mapY = aaVarB.y();
            if (mapY != null && mapY.size() > 0) {
                for (Map.Entry<String, String> entry : mapY.entrySet()) {
                    bvVar2.e.put("C04_" + entry.getKey(), entry.getValue());
                }
            }
            if (i == 1) {
                bvVar2.f3790a = (byte) 1;
            } else if (i != 2) {
                al.e("unknown up type %d ", Integer.valueOf(i));
            } else {
                bvVar2.f3790a = (byte) 2;
            }
            bvVar = bvVar2;
        }
        if (bvVar == null) {
            al.d("[UserInfo] Failed to create UserInfoPackage.", new Object[0]);
            return;
        }
        byte[] bArrA = ae.a((m) bvVar);
        if (bArrA == null) {
            al.d("[UserInfo] Failed to encode data.", new Object[0]);
            return;
        }
        bq bqVarA = ae.a(this.f3800a, 840, bArrA);
        if (bqVarA == null) {
            al.d("[UserInfo] Request package is null.", new Object[0]);
            return;
        }
        ai.a().a(1001, bqVarA, ac.a().c().q, StrategyBean.f3717a, new ah() { // from class: com.tencent.bugly.proguard.r.1
            @Override // com.tencent.bugly.proguard.ah
            public final void a(boolean z2, String str) {
                if (z2) {
                    al.c("[UserInfo] Successfully uploaded user info.", new Object[0]);
                    long jCurrentTimeMillis2 = System.currentTimeMillis();
                    for (UserInfoBean userInfoBean2 : list) {
                        userInfoBean2.f = jCurrentTimeMillis2;
                        r.this.a(userInfoBean2, true);
                    }
                }
            }
        }, this.c == 1);
    }

    public final void b() {
        ak akVarA = ak.a();
        if (akVarA != null) {
            akVarA.a(new Runnable() { // from class: com.tencent.bugly.proguard.r.2

                /* JADX INFO: renamed from: a, reason: collision with root package name */
                final /* synthetic */ boolean f3802a = false;

                @Override // java.lang.Runnable
                public final void run() {
                    try {
                        r.this.a(this.f3802a);
                    } catch (Throwable th) {
                        al.a(th);
                    }
                }
            });
        }
    }

    /* JADX INFO: compiled from: BUGLY */
    class b implements Runnable {
        b() {
        }

        @Override // java.lang.Runnable
        public final void run() {
            long jCurrentTimeMillis = System.currentTimeMillis();
            if (jCurrentTimeMillis < r.this.b) {
                ak.a().a(r.this.new b(), (r.this.b - jCurrentTimeMillis) + 5000);
            } else {
                r.this.a(3, false);
                r.this.a();
            }
        }
    }

    /* JADX INFO: compiled from: BUGLY */
    class c implements Runnable {
        private long b;

        public c(long j) {
            this.b = j;
        }

        @Override // java.lang.Runnable
        public final void run() {
            r.this.b();
            r.this.a(this.b);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(UserInfoBean userInfoBean, boolean z) {
        List<UserInfoBean> listA;
        if (userInfoBean == null) {
            return;
        }
        if (!z && userInfoBean.b != 1 && (listA = a(aa.a(this.f3800a).d)) != null && listA.size() >= 20) {
            al.a("[UserInfo] There are too many user info in local: %d", Integer.valueOf(listA.size()));
            return;
        }
        long jA = w.a().a("t_ui", b(userInfoBean), (v) null);
        if (jA >= 0) {
            al.c("[Database] insert %s success with ID: %d", "t_ui", Long.valueOf(jA));
            userInfoBean.f3715a = jA;
        }
    }

    public static List<UserInfoBean> a(String str) {
        Cursor cursorA;
        try {
            cursorA = w.a().a("t_ui", (String[]) null, ap.b(str) ? null : "_pc = '" + str + "'");
            if (cursorA == null) {
                if (cursorA != null) {
                    cursorA.close();
                }
                return null;
            }
            try {
                StringBuilder sb = new StringBuilder();
                ArrayList arrayList = new ArrayList();
                while (cursorA.moveToNext()) {
                    UserInfoBean userInfoBeanA = a(cursorA);
                    if (userInfoBeanA != null) {
                        arrayList.add(userInfoBeanA);
                    } else {
                        try {
                            sb.append(" or _id = ").append(cursorA.getLong(cursorA.getColumnIndex("_id")));
                        } catch (Throwable unused) {
                            al.d("[Database] unknown id.", new Object[0]);
                        }
                    }
                }
                String string = sb.toString();
                if (string.length() > 0) {
                    al.d("[Database] deleted %s error data %d", "t_ui", Integer.valueOf(w.a().a("t_ui", string.substring(4))));
                }
                if (cursorA != null) {
                    cursorA.close();
                }
                return arrayList;
            } catch (Throwable th) {
                th = th;
                try {
                    if (!al.a(th)) {
                        th.printStackTrace();
                    }
                    return null;
                } finally {
                    if (cursorA != null) {
                        cursorA.close();
                    }
                }
            }
        } catch (Throwable th2) {
            th = th2;
            cursorA = null;
        }
    }

    private static void b(List<UserInfoBean> list) {
        if (list.size() == 0) {
            return;
        }
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < list.size() && i < 50; i++) {
            sb.append(" or _id = ").append(list.get(i).f3715a);
        }
        String string = sb.toString();
        if (string.length() > 0) {
            string = string.substring(4);
        }
        sb.setLength(0);
        try {
            al.c("[Database] deleted %s data %d", "t_ui", Integer.valueOf(w.a().a("t_ui", string)));
        } catch (Throwable th) {
            if (al.a(th)) {
                return;
            }
            th.printStackTrace();
        }
    }

    private static ContentValues b(UserInfoBean userInfoBean) {
        if (userInfoBean == null) {
            return null;
        }
        try {
            ContentValues contentValues = new ContentValues();
            if (userInfoBean.f3715a > 0) {
                contentValues.put("_id", Long.valueOf(userInfoBean.f3715a));
            }
            contentValues.put("_tm", Long.valueOf(userInfoBean.e));
            contentValues.put("_ut", Long.valueOf(userInfoBean.f));
            contentValues.put("_tp", Integer.valueOf(userInfoBean.b));
            contentValues.put("_pc", userInfoBean.c);
            contentValues.put("_dt", ap.a(userInfoBean));
            return contentValues;
        } catch (Throwable th) {
            if (!al.a(th)) {
                th.printStackTrace();
            }
            return null;
        }
    }

    private static UserInfoBean a(Cursor cursor) {
        if (cursor == null) {
            return null;
        }
        try {
            byte[] blob = cursor.getBlob(cursor.getColumnIndex("_dt"));
            if (blob == null) {
                return null;
            }
            long j = cursor.getLong(cursor.getColumnIndex("_id"));
            UserInfoBean userInfoBean = (UserInfoBean) ap.a(blob, UserInfoBean.CREATOR);
            if (userInfoBean != null) {
                userInfoBean.f3715a = j;
            }
            return userInfoBean;
        } catch (Throwable th) {
            if (!al.a(th)) {
                th.printStackTrace();
            }
            return null;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code duplicated, block: B:30:0x0067 A[Catch: all -> 0x0092, TryCatch #0 {, blocks: (B:3:0x0001, B:21:0x002b, B:23:0x003e, B:25:0x004c, B:28:0x0061, B:30:0x0067, B:32:0x006c, B:35:0x0073, B:38:0x0089, B:26:0x005b, B:6:0x0009, B:9:0x0010, B:12:0x0017, B:14:0x001d), top: B:44:0x0001 }] */
    public synchronized void a(boolean z) {
        ai aiVarA;
        ac acVarA;
        boolean z2;
        if (this.d && (aiVarA = ai.a()) != null && (acVarA = ac.a()) != null && (!acVarA.b() || aiVarA.b(1001))) {
            String str = aa.a(this.f3800a).d;
            ArrayList arrayList = new ArrayList();
            List<UserInfoBean> listA = a(str);
            if (listA != null) {
                a(listA, arrayList);
                b(listA, arrayList);
                int iA = a(listA);
                if (iA > 15) {
                    al.d("[UserInfo] Upload user info too many times in 10 min: %d", Integer.valueOf(iA));
                    z2 = false;
                }
                if (arrayList.size() > 0) {
                    b(arrayList);
                }
                if (z2 && listA.size() != 0) {
                    al.c("[UserInfo] Upload user info(size: %d)", Integer.valueOf(listA.size()));
                    a(listA, z);
                    return;
                }
                al.c("[UserInfo] There is no user info in local database.", new Object[0]);
            }
            listA = new ArrayList<>();
            z2 = true;
            if (arrayList.size() > 0) {
                b(arrayList);
            }
            if (z2) {
                al.c("[UserInfo] Upload user info(size: %d)", Integer.valueOf(listA.size()));
                a(listA, z);
                return;
            }
            al.c("[UserInfo] There is no user info in local database.", new Object[0]);
        }
    }

    /* JADX WARN: Code duplicated, block: B:42:0x0093 A[Catch: Exception -> 0x0080, TRY_ENTER, TRY_LEAVE, TryCatch #0 {Exception -> 0x0080, blocks: (B:42:0x0093, B:30:0x007c, B:14:0x0039, B:16:0x004d, B:22:0x005c, B:25:0x0067), top: B:44:0x0037, inners: #3 }] */
    private boolean b(boolean z) {
        boolean z2 = true;
        if (!e) {
            return true;
        }
        File file = new File(this.f3800a.getFilesDir(), "bugly_last_us_up_tm");
        long jCurrentTimeMillis = System.currentTimeMillis();
        if (z) {
            am.a(file, String.valueOf(jCurrentTimeMillis), 1024L, false);
            return true;
        }
        if (!file.exists()) {
            am.a(file, String.valueOf(jCurrentTimeMillis), 1024L, false);
        } else {
            BufferedReader bufferedReaderA = ap.a(file);
            try {
                if (bufferedReaderA != null) {
                    try {
                        long jLongValue = Long.valueOf(bufferedReaderA.readLine().trim()).longValue();
                        if (!(jCurrentTimeMillis >= jLongValue && jCurrentTimeMillis - jLongValue <= 86400000) || jCurrentTimeMillis - jLongValue >= 300000) {
                            am.a(file, String.valueOf(jCurrentTimeMillis), 1024L, false);
                        } else {
                            z2 = false;
                        }
                        if (bufferedReaderA != null) {
                            bufferedReaderA.close();
                        }
                    } catch (Throwable th) {
                        try {
                            al.b(th);
                            am.a(file, String.valueOf(jCurrentTimeMillis), 1024L, false);
                            if (bufferedReaderA != null) {
                                bufferedReaderA.close();
                            }
                        } catch (Throwable th2) {
                            if (bufferedReaderA != null) {
                                try {
                                    bufferedReaderA.close();
                                } catch (Exception e2) {
                                    al.a(e2);
                                }
                            }
                            throw th2;
                        }
                    }
                } else if (bufferedReaderA != null) {
                    bufferedReaderA.close();
                }
            } catch (Exception e3) {
                al.a(e3);
            }
        }
        return z2;
    }

    static /* synthetic */ void a(UserInfoBean userInfoBean) {
        aa aaVarB;
        if (userInfoBean == null || (aaVarB = aa.b()) == null) {
            return;
        }
        userInfoBean.j = aaVarB.d();
    }
}
