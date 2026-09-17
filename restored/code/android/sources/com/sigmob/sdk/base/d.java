package com.sigmob.sdk.base;

import android.net.Uri;
import android.text.TextUtils;
import android.webkit.URLUtil;
import android.webkit.WebResourceResponse;
import com.czhj.sdk.logger.SigmobLogger;
import com.sigmob.sdk.base.utils.x;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    static e f3208a = null;
    private static final String b = "d";

    static {
        try {
            if (o.a().Z()) {
                f3208a = new f();
            }
        } catch (Throwable unused) {
        }
        if (f3208a == null) {
            f3208a = new e();
        }
    }

    public static WebResourceResponse a(Uri url) {
        return null;
    }

    static WebResourceResponse a(String url, String method, Map<String, String> map) {
        e eVar;
        if (x.a(url)) {
            return null;
        }
        if ((URLUtil.isHttpUrl(url) || URLUtil.isHttpsUrl(url)) && !method.equals("POST") && (eVar = f3208a) != null) {
            try {
                return eVar.a(url, method, map);
            } catch (Throwable unused) {
            }
        }
        return null;
    }

    public static boolean a(String url) {
        try {
            Uri uri = Uri.parse(url);
            String host = uri.getHost();
            String scheme = uri.getScheme();
            String lastPathSegment = uri.getLastPathSegment();
            if (host == null || l.a(url) || !scheme.startsWith("http") || host.equals("localhost") || host.equals("127.0.0.1") || !TextUtils.isEmpty(uri.getQueryParameter("no-cache"))) {
                return true;
            }
            if (!lastPathSegment.endsWith(".js") && !lastPathSegment.endsWith(".css")) {
                return true;
            }
        } catch (Throwable th) {
            SigmobLogger.e(b, "filterUrl: error = " + th.getMessage(), new Object[0]);
        }
        return false;
    }
}
