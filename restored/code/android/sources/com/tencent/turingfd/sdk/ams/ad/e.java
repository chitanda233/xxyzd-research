package com.tencent.turingfd.sdk.ams.ad;

import android.text.TextUtils;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public abstract class e {
    public static TuringSDK H;
    public static final d I = new d();
    public HashSet B;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public Dorado f3923a;
    public ITuringPrivacyPolicy b;
    public ITuringDeviceInfoProvider c;
    public ITuringPkgProvider d;
    public ITuringIoTFeatureMap e;
    public int f = 0;
    public String g = "";
    public boolean h = true;
    public String[] i = null;
    public String j = "";
    public String k = "";
    public String l = "";
    public int m = 0;
    public String n = "";
    public Map o = new HashMap();
    public String p = "";
    public boolean q = false;
    public boolean r = false;
    public boolean s = true;
    public boolean t = true;
    public boolean u = false;
    public long v = 5000;
    public long w = 60000;
    public int x = 3;
    public boolean y = false;
    public boolean z = false;
    public boolean A = false;
    public boolean C = false;
    public boolean D = false;
    public boolean E = false;
    public boolean F = false;
    public boolean G = false;

    public static synchronized void a(TuringSDK turingSDK) {
        H = turingSDK;
    }

    public static synchronized void b() {
    }

    public final void a() {
        String[] strArr = this.i;
        if (strArr != null) {
            if (strArr.length == 0) {
                this.i = null;
            } else {
                ArrayList arrayList = new ArrayList();
                for (String str : this.i) {
                    if (str != null && !str.isEmpty()) {
                        arrayList.add(str);
                    }
                }
                this.i = arrayList.isEmpty() ? null : (String[]) arrayList.toArray(new String[0]);
            }
        }
        if (this.i == null) {
            if (TextUtils.isEmpty("https://tdid.m.qq.com/tmf")) {
                this.i = new String[]{""};
            } else {
                this.i = new String[]{"https://tdid.m.qq.com/tmf"};
            }
        }
        if (this.f3923a == null) {
            String[] strArr2 = this.i;
            Dorado dorado = new Dorado(strArr2);
            if (strArr2.length > 1) {
                Ara.f3820a.submit(new Cygnus(dorado));
            }
            this.f3923a = dorado;
        } else {
            this.y = true;
        }
        if (this.B == null) {
            this.B = new HashSet();
        }
        if (this.E) {
            this.B.add(155);
        }
    }
}
