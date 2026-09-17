package com.onevcat.uniwebview;

import android.webkit.CookieManager;
import android.webkit.ValueCallback;
import java.util.Iterator;
import java.util.List;
import kotlin.jvm.internal.Intrinsics;
import kotlin.text.Regex;
import kotlin.text.StringsKt;

/* JADX INFO: loaded from: classes3.dex */
public abstract class P {
    public static void a() {
        final CookieManager cookieManager = CookieManager.getInstance();
        cookieManager.removeAllCookies(new ValueCallback() { // from class: com.onevcat.uniwebview.P$$ExternalSyntheticLambda0
            @Override // android.webkit.ValueCallback
            public final void onReceiveValue(Object obj) {
                P.a(cookieManager, (Boolean) obj);
            }
        });
    }

    public static void b() {
        CookieManager.getInstance().flush();
    }

    public static final void a(CookieManager cookieManager, Boolean bool) {
        cookieManager.flush();
        C0654l c0654l = C0654l.b;
        C0654l c0654l2 = C0654l.b;
        c0654l2.getClass();
        Intrinsics.checkNotNullParameter("Cookie manager flush done.", "message");
        c0654l2.a(EnumC0651k.VERBOSE, "Cookie manager flush done.");
    }

    public static void b(String url, String cookie) {
        Intrinsics.checkNotNullParameter(url, "url");
        Intrinsics.checkNotNullParameter(cookie, "cookie");
        C0654l c0654l = C0654l.b;
        String message = O.a("Cookie set for url: ", url, ", cookie: ", cookie, c0654l);
        Intrinsics.checkNotNullParameter(message, "message");
        EnumC0651k enumC0651k = EnumC0651k.VERBOSE;
        c0654l.a(enumC0651k, message);
        CookieManager cookieManager = CookieManager.getInstance();
        cookieManager.setCookie(url, cookie);
        cookieManager.flush();
        Intrinsics.checkNotNullParameter("Cookie manager flush done.", "message");
        c0654l.a(enumC0651k, "Cookie manager flush done.");
    }

    public static void a(String url, String str) {
        Intrinsics.checkNotNullParameter(url, "url");
        C0654l c0654l = C0654l.b;
        String message = O.a("Cookie remove for url: ", url, ", key: ", str, c0654l);
        Intrinsics.checkNotNullParameter(message, "message");
        EnumC0651k enumC0651k = EnumC0651k.VERBOSE;
        c0654l.a(enumC0651k, message);
        CookieManager cookieManager = CookieManager.getInstance();
        String cookie = cookieManager.getCookie(url);
        if (cookie == null) {
            String message2 = "The content for given url '" + url + "' is not found in cookie manager.";
            Intrinsics.checkNotNullParameter(message2, "message");
            c0654l.a(EnumC0651k.DEBUG, message2);
            return;
        }
        String message3 = "Cookie string is found: '" + cookie + "', for url: " + url;
        Intrinsics.checkNotNullParameter(message3, "message");
        c0654l.a(enumC0651k, message3);
        Iterator<String> it = new Regex(com.alipay.sdk.m.y.l.b).split(cookie, 0).iterator();
        while (it.hasNext()) {
            List<String> listSplit = new Regex("=").split(StringsKt.trim((CharSequence) it.next()).toString(), 0);
            if (listSplit.size() >= 2 && (str == null || Intrinsics.areEqual(str, listSplit.get(0)))) {
                cookieManager.setCookie(url, listSplit.get(0) + com.alipay.sdk.m.p.a.h);
            }
        }
    }
}
