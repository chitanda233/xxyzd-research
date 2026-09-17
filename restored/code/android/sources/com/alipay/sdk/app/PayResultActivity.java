package com.alipay.sdk.app;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.os.Handler;
import android.text.TextUtils;
import com.alipay.sdk.m.y.g;
import java.io.UnsupportedEncodingException;
import java.net.URLEncoder;
import java.util.HashMap;

/* JADX INFO: loaded from: classes.dex */
public final class PayResultActivity extends Activity {
    public static final String b = "{\"isLogin\":\"false\"}";
    public static final HashMap<String, Object> c = new HashMap<>();
    public static final String d = "hk.alipay.wallet";
    public static final String e = "phonecashier.pay.hash";
    public static final String f = "orderSuffix";
    public static final String g = "externalPkgName";
    public static final String h = "phonecashier.pay.result";
    public static final String i = "phonecashier.pay.resultOrderHash";

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public com.alipay.sdk.m.w.a f223a = null;

    public class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public final /* synthetic */ Activity f224a;

        public a(Activity activity) {
            this.f224a = activity;
        }

        @Override // java.lang.Runnable
        public void run() {
            this.f224a.finish();
        }
    }

    public static final class b {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static volatile String f225a;
        public static volatile String b;
    }

    public static void a(Activity activity, String str, String str2, String str3) {
        if (TextUtils.isEmpty(str2) || TextUtils.isEmpty(str3)) {
            return;
        }
        Intent intent = new Intent();
        try {
            intent.setPackage("hk.alipay.wallet");
            intent.setData(Uri.parse("alipayhk://platformapi/startApp?appId=20000125&schemePaySession=" + URLEncoder.encode(str, "UTF-8") + "&orderSuffix=" + URLEncoder.encode(str2, "UTF-8") + "&packageName=" + URLEncoder.encode(str3, "UTF-8") + "&externalPkgName=" + URLEncoder.encode(str3, "UTF-8")));
        } catch (UnsupportedEncodingException e2) {
            g.a(e2);
        }
        if (activity != null) {
            try {
                activity.startActivity(intent);
            } catch (Throwable unused) {
                activity.finish();
            }
        }
    }

    @Override // android.app.Activity
    public void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        try {
            Intent intent = getIntent();
            if (!TextUtils.isEmpty(intent.getStringExtra(f))) {
                b.f225a = intent.getStringExtra(e);
                String stringExtra = intent.getStringExtra(f);
                String stringExtra2 = intent.getStringExtra(g);
                com.alipay.sdk.m.w.a aVarA = com.alipay.sdk.m.w.a.C0054a.a(intent);
                this.f223a = aVarA;
                if (aVarA == null) {
                    finish();
                }
                a(this, b.f225a, stringExtra, stringExtra2);
                a(this, 300);
                return;
            }
            if (this.f223a == null) {
                finish();
            }
            String stringExtra3 = intent.getStringExtra(h);
            int intExtra = intent.getIntExtra(i, 0);
            if (intExtra != 0 && TextUtils.equals(b.f225a, String.valueOf(intExtra))) {
                if (TextUtils.isEmpty(stringExtra3)) {
                    a(b.f225a);
                } else {
                    a(stringExtra3, b.f225a);
                }
                b.f225a = "";
                a(this, 300);
                return;
            }
            com.alipay.sdk.m.m.a.b(this.f223a, com.alipay.sdk.m.m.b.l, com.alipay.sdk.m.m.b.l0, "Expected " + b.f225a + ", got " + intExtra);
            a(b.f225a);
            a(this, 300);
        } catch (Throwable unused) {
            finish();
        }
    }

    public static void a(String str) {
        b.b = com.alipay.sdk.m.l.b.a();
        a(c, str);
    }

    public static void a(String str, String str2) {
        b.b = str;
        a(c, str2);
    }

    public static void a(Activity activity, int i2) {
        new Handler().postDelayed(new a(activity), i2);
    }

    public static boolean a(HashMap<String, Object> map, String str) {
        Object obj;
        if (map == null || str == null || (obj = map.get(str)) == null) {
            return false;
        }
        synchronized (obj) {
            obj.notifyAll();
        }
        return true;
    }
}
