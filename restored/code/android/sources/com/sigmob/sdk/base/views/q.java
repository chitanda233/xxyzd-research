package com.sigmob.sdk.base.views;

import android.app.Activity;
import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.graphics.Bitmap;
import android.net.Uri;
import android.net.http.SslError;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.util.Base64;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.webkit.ConsoleMessage;
import android.webkit.JavascriptInterface;
import android.webkit.SslErrorHandler;
import android.webkit.WebChromeClient;
import android.webkit.WebResourceError;
import android.webkit.WebResourceRequest;
import android.webkit.WebResourceResponse;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.common.utils.Md5Util;
import com.czhj.sdk.common.utils.TouchLocation;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.volley.toolbox.StringUtil;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.rtb.AdPrivacy;
import com.sigmob.sdk.base.models.rtb.MaterialMeta;
import com.sigmob.windad.WindAdRequest;
import java.io.File;
import java.util.Map;
import kotlinx.coroutines.scheduling.WorkQueueKt;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class q extends Dialog implements DialogInterface.OnDismissListener, DialogInterface.OnShowListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3351a = "q";
    private b b;
    private Map<String, String> c;
    private Context d;
    private Window e;
    private g f;
    private final BaseAdUnit g;
    private ImageView h;
    private String i;
    private File j;
    private boolean k;
    private RelativeLayout l;
    private Handler m;
    private Activity n;
    private int o;

    static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final Map<String, String> f3354a;

        public a(Map<String, String> privacy) {
            this.f3354a = privacy;
        }

        @JavascriptInterface
        public String getPrivacyInfo() {
            Map<String, String> map = this.f3354a;
            if (map != null && !map.isEmpty()) {
                try {
                    JSONObject jSONObject = new JSONObject();
                    for (Map.Entry<String, String> entry : this.f3354a.entrySet()) {
                        jSONObject.put(entry.getKey(), entry.getValue());
                    }
                    return jSONObject.toString();
                } catch (Throwable th) {
                    com.sigmob.sdk.base.utils.k.f(q.f3351a, "getPrivacyInfo: error = " + th.getMessage(), new Object[0]);
                }
            }
            return null;
        }
    }

    public interface b {
        void a();

        void a(Error error);

        void a(String url, String clickCoordinate);

        void b();
    }

    public q(Context context, BaseAdUnit adUnit) {
        super(context, com.sigmob.sdk.base.k.f());
        this.e = null;
        this.i = "";
        this.d = context.getApplicationContext();
        this.g = adUnit;
        this.f = b();
        this.h = f();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(View view) {
        b bVar = this.b;
        if (bVar == null) {
            return;
        }
        bVar.a();
    }

    private void e() {
        if (com.sigmob.sdk.base.utils.v.b(this.g)) {
            MaterialMeta material = this.g.getMaterial();
            if (material == null || material.ad_privacy == null) {
                SigmobLog.d("showWebView: ad_privacy is null.");
            } else {
                AdPrivacy adPrivacy = material.ad_privacy;
                if (com.sigmob.sdk.base.utils.f.b(adPrivacy.privacy_template_info)) {
                    this.c = adPrivacy.privacy_template_info;
                }
                if (com.sigmob.sdk.base.utils.s.b(adPrivacy.privacy_template_url)) {
                    this.j = com.sigmob.sdk.base.utils.n.a(com.sigmob.sdk.base.utils.n.d(com.sigmob.sdk.base.utils.n.b), Md5Util.md5(adPrivacy.privacy_template_url) + ".html");
                }
            }
        }
        boolean z = com.sigmob.sdk.base.utils.v.b(this.j) && this.j.exists();
        if (com.sigmob.sdk.base.utils.s.b(this.i)) {
            this.f.loadUrl(this.i);
            return;
        }
        this.f.addJavascriptInterface(new a(this.c), "sigPrivacy");
        if (z) {
            this.f.loadUrl("file://" + this.j.getAbsolutePath());
        } else {
            this.f.loadDataWithBaseURL(null, new String(Base64.decode("PCFET0NUWVBFIGh0bWw+CjxodG1sIGxhbmc9ImVuIj4KPGhlYWQ+CiAgICA8bWV0YSBjaGFyc2V0PSJVVEYtOCI+CiAgICA8bWV0YSBuYW1lPSJ2aWV3cG9ydCIKICAgICAgICAgIGNvbnRlbnQ9IndpZHRoPWRldmljZS13aWR0aCxpbml0aWFsLXNjYWxlPTEsbWF4aW11bS1zY2FsZT0xLHVzZXItc2NhbGFibGU9MCI+CiAgICA8bWV0YSBjb250ZW50PSJ5ZXMiIG5hbWU9ImFwcGxlLW1vYmlsZS13ZWItYXBwLWNhcGFibGUiPgogICAgPG1ldGEgaHR0cC1lcXVpdj0iWC1VQS1Db21wYXRpYmxlIiBjb250ZW50PSJJRT1lZGdlLGNocm9tZT0xIj4KICAgIDxtZXRhIG5hbWU9InJlbmRlcmVyIiBjb250ZW50PSJ3ZWJraXQiPgogICAgPGxpbmsgcmVsPSJpY29uIiBocmVmPSJkYXRhOmltYWdlL2ljbztiYXNlNjQsYVdOdiI+CiAgICA8dGl0bGU+5paw54mINuimgee0oDY2NjI8L3RpdGxlPgogICAgPHN0eWxlPmh0bWwsIGJvZHksICNhcHAgewogICAgICBtYXJnaW46IDA7CiAgICAgIHdpZHRoOiAxMDB2dzsKICAgICAgaGVpZ2h0OiAxMDB2aDsKICAgICAgb3ZlcmZsb3c6IGhpZGRlbjsKICAgICAgYmFja2dyb3VuZDogdHJhbnNwYXJlbnQgIWltcG9ydGFudDsKICAgIH0KICAgICNlcnJvcl9tYXNrIHsKICAgICAgZGlzcGxheTogbm9uZTsKICAgICAgZmxleC1kaXJlY3Rpb246IGNvbHVtbjsKICAgICAgd2lkdGg6IDEwMHZ3OwogICAgICBoZWlnaHQ6IDEwMHZoOwogICAgICBhbGlnbi1pdGVtczogY2VudGVyOwogICAgICBqdXN0aWZ5LWNvbnRlbnQ6IGNlbnRlcjsKICAgICAgYmFja2dyb3VuZDogcmdiYSgwLDAsMCwwLjYpOwogICAgfQogICAgI2Vycm9yX21hc2sgLmNsb3NlIHsKICAgICAgei1pbmRleDogOTk5OTsKICAgICAgd2lkdGg6IDI4cHg7CiAgICAgIGhlaWdodDogMjhweDsKICAgICAgYmFja2dyb3VuZC1jb2xvcjogI2UzMzEyMjsKICAgICAgY29sb3I6ICNmZmY7CiAgICAgIHBhZGRpbmc6IDRweDsKICAgICAgYm9yZGVyLXJhZGl1czogNTAlOwogICAgICB0b3A6IDEwcHg7CiAgICAgIHJpZ2h0OiAxMHB4OwogICAgfQogICAgI2Vycm9yX21hc2sgLmVycm9yIHsKICAgICAgZm9udC1zaXplOiAyMHB4OwogICAgICBjb2xvcjogI2UzMzEyMjsKICAgICAgbWFyZ2luLWJvdHRvbTogMjBweDsKICAgIH0KICAgIDwvc3R5bGU+CiAgICA8ZGl2IGlkPSJlcnJvcl9tYXNrIj48cCBjbGFzcz0iZXJyb3IiPuWFreimgee0oOWKoOi9veWksei0pX48L3A+CiAgICAgICAgPHN2ZyBjbGFzcz0iY2xvc2UiIGlkPSJjbG9zZSIgZmlsbD0iY3VycmVudENvbG9yIiB0PSIxNTk1NDc1OTMzNzE2IiBjbGFzcz0iaWNvbiIKICAgICAgICAgICAgIHZpZXdCb3g9IjAgMCAxMDI0IDEwMjQiIHZlcnNpb249IjEuMSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiBwLWlkPSIyMDExIgogICAgICAgICAgICAgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiPgogICAgICAgICAgICA8cGF0aCBkPSJNMTAzLjY4OCA5MzguNTc2YTI4IDI4IDAgMCAxLTE5LjgtNDcuOEw4OTguMTUyIDc2LjUyYTI4IDI4IDAgMSAxIDM5LjYgMzkuNTkyTDEyMy40ODggOTMwLjRhMjcuOTIgMjcuOTIgMCAwIDEtMTkuOCA4LjE3NnoiPjwvcGF0aD4KICAgICAgICAgICAgPHBhdGggZD0iTTkxNy45NTIgOTM4LjU3NmEyNy45MjggMjcuOTI4IDAgMCAxLTE5LjgtOC4yTDgzLjg4OCAxMTYuMTEyYTI4IDI4IDAgMCAxIDM5LjYtMzkuNTkybDgxNC4yNjQgODE0LjI1NmEyOCAyOCAwIDAgMS0xOS44IDQ3Ljh6Ij48L3BhdGg+CiAgICAgICAgPC9zdmc+CiAgICA8L2Rpdj4KICAgIDxzY3JpcHQ+ZnVuY3Rpb24gaWZyYW1lU2VuZFNyYyhzcmMpIHsKICAgICAgdmFyIGlmcmFtZSA9IGRvY3VtZW50LmNyZWF0ZUVsZW1lbnQoJ2lmcmFtZScpCiAgICAgIGlmcmFtZS5zZXRBdHRyaWJ1dGUoJ3NyYycsIHNyYykKICAgICAgZG9jdW1lbnQuZG9jdW1lbnRFbGVtZW50LmFwcGVuZENoaWxkKGlmcmFtZSkKICAgICAgaWZyYW1lLnBhcmVudE5vZGUucmVtb3ZlQ2hpbGQoaWZyYW1lKQogICAgICBpZnJhbWUgPSBudWxsCiAgICB9CgogICAgc2V0VGltZW91dCgoKSA9PiB7CiAgICAgIGlmICghd2luZG93LklOSVQpIHsKICAgICAgICBjb25zdCBlcnJvck1hc2sgPSBkb2N1bWVudC5nZXRFbGVtZW50QnlJZCgnZXJyb3JfbWFzaycpCiAgICAgICAgY29uc3QgY2xvc2VEb20gPSBkb2N1bWVudC5nZXRFbGVtZW50QnlJZCgnY2xvc2UnKQogICAgICAgIGVycm9yTWFzay5zdHlsZS5kaXNwbGF5ID0gJ2ZsZXgnCiAgICAgICAgY2xvc2VEb20ub25jbGljayA9IGZ1bmN0aW9uICgpIHsKICAgICAgICAgIGlmcmFtZVNlbmRTcmMoJ3NpZ21vYkFkOi8vY2xvc2VGb3VyRWxlbWVudHMnKQogICAgICAgIH0KICAgICAgfQogICAgfSwgMzAwMCkKICAgIDwvc2NyaXB0PgogICAgPGxpbmsgaHJlZj0iaHR0cHM6Ly9uLnNpZ21vYi5jbi9tcmFpZC9wcm9kLzY2NjIvNjY2Mi5hMzM2ZDVlMS5qcyIgcmVsPSJwcmVsb2FkIiBhcz0ic2NyaXB0Ij4KICAgIDxsaW5rIGhyZWY9Imh0dHBzOi8vbi5zaWdtb2IuY24vbXJhaWQvcHJvZC82NjYyLzY2NjIuYzc1MDZhMDcuY3NzIiByZWw9InByZWxvYWQiIGFzPSJzdHlsZSI+CiAgICA8bGluayBocmVmPSJodHRwczovL24uc2lnbW9iLmNuL21yYWlkL3Byb2QvNjY2Mi82NjYyLmM3NTA2YTA3LmNzcyIgcmVsPSJzdHlsZXNoZWV0Ij4KICAgIDxzY3JpcHQ+CiAgICAgICAgdmFyIHNpZ21vYj13aW5kb3cuc2lnbW9iPXt9LHByaXZhY3lJbmZvPXt9LGlmcmFtZVNlbmRTcmM9ZnVuY3Rpb24oaSl7dmFyIG89ZG9jdW1lbnQuY3JlYXRlRWxlbWVudCgiaWZyYW1lIik7by5zZXRBdHRyaWJ1dGUoInNyYyIsaSksZG9jdW1lbnQuZG9jdW1lbnRFbGVtZW50LmFwcGVuZENoaWxkKG8pLG8ucGFyZW50Tm9kZS5yZW1vdmVDaGlsZChvKX0saW5pdFByaXZhY3lJbmZvPShzaWdtb2IuZ2V0UHJpdmFjeUluZm89ZnVuY3Rpb24oKXtyZXR1cm4gcHJpdmFjeUluZm99LHNpZ21vYi5jbG9zZUZvdXJFbGVtZW50cz1mdW5jdGlvbigpe2lmcmFtZVNlbmRTcmMoInNpZ21vYkFkOi8vY2xvc2VGb3VyRWxlbWVudHMiKX0sc2lnbW9iLnVzZUN1c3RvbUNsb3NlPWZ1bmN0aW9uKCl7aWZyYW1lU2VuZFNyYygic2lnbW9iQWQ6Ly91c2VDdXN0b21DbG9zZSIpfSxzaWdtb2IuYnV0dG9uQ2xpY2s9ZnVuY3Rpb24oaSxvLG4pe2lmcmFtZVNlbmRTcmMobj8ic2lnbW9iQWQ6Ly9idXR0b25DbGljaz91cmw9IituKyImeD0iK2krIiZ5PSIrbzoic2lnbW9iQWQ6Ly9idXR0b25DbGljaz94PSIraSsiJnk9IitvKX0sZnVuY3Rpb24oKXt3aW5kb3cuc2lnUHJpdmFjeT9wcml2YWN5SW5mbz13aW5kb3cuc2lnUHJpdmFjeS5nZXRQcml2YWN5SW5mbygpOmNvbnNvbGUuZXJyb3IoInNpZ1ByaXZhY3nms6jlhozlpLHotKU9PT0iKX0pO2luaXRQcml2YWN5SW5mbygpOwogICAgPC9zY3JpcHQ+CjwvaGVhZD4KPGJvZHk+CjxkaXYgaWQ9ImFwcCI+PC9kaXY+CjxzY3JpcHQgc3JjPSJodHRwczovL24uc2lnbW9iLmNuL21yYWlkL3Byb2QvNjY2Mi82NjYyLmEzMzZkNWUxLmpzIj48L3NjcmlwdD4KPC9ib2R5Pgo8L2h0bWw+", 0)), "text/html", "utf-8", null);
            com.sigmob.sdk.base.common.ad.a("h5_error", "download_dialog", 0, " error: htmlUrl: " + this.i + " htmlFile " + this.j + " exists " + z, (WindAdRequest) null, (LoadAdRequest) null, this.g, (com.sigmob.sdk.base.common.ad.a) null);
        }
    }

    private ImageView f() {
        ImageView imageView = new ImageView(this.d);
        this.h = imageView;
        imageView.setImageBitmap(s.CLOSE.a());
        this.h.setScaleType(ImageView.ScaleType.CENTER_CROP);
        this.h.setImageAlpha(WorkQueueKt.MASK);
        this.h.setClickable(true);
        this.h.setOnClickListener(new View.OnClickListener() { // from class: com.sigmob.sdk.base.views.q$$ExternalSyntheticLambda0
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                this.f$0.a(view);
            }
        });
        return this.h;
    }

    private void g() {
        if (this.h == null) {
            return;
        }
        int iDipsToIntPixels = Dips.dipsToIntPixels(18.0f, this.d);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(iDipsToIntPixels, iDipsToIntPixels);
        layoutParams.addRule(10);
        layoutParams.addRule(11);
        int i = iDipsToIntPixels / 2;
        layoutParams.setMargins(0, i, i, 0);
        this.l.addView(this.h, layoutParams);
    }

    private void h() {
        Window window = getWindow();
        this.e = window;
        if (window == null) {
            return;
        }
        WindowManager.LayoutParams attributes = window.getAttributes();
        attributes.width = -1;
        attributes.height = -1;
        this.e.setAttributes(attributes);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void i() {
        if (this.k) {
            return;
        }
        g();
    }

    public void a(b clickListener) {
        this.b = clickListener;
    }

    public boolean a() {
        return true;
    }

    public g b() {
        g gVar = new g(this.d);
        this.f = gVar;
        gVar.a(true);
        this.f.setAdUnit(this.g);
        this.f.a((com.sigmob.sdk.base.common.b) null);
        this.f.setBackgroundColor(0);
        this.f.setWebChromeClient(new WebChromeClient() { // from class: com.sigmob.sdk.base.views.q.1
            @Override // android.webkit.WebChromeClient
            public boolean onConsoleMessage(ConsoleMessage consoleMessage) {
                ConsoleMessage.MessageLevel messageLevel = consoleMessage.messageLevel();
                if (messageLevel != null && messageLevel == ConsoleMessage.MessageLevel.ERROR) {
                    SigmobLog.e(q.f3351a + "onConsoleMessage: msg = " + consoleMessage.message());
                    com.sigmob.sdk.base.common.ad.a("h5_error", "download_dialog", 0, consoleMessage.message(), (WindAdRequest) null, (LoadAdRequest) null, q.this.g, (com.sigmob.sdk.base.common.ad.a) null);
                }
                return false;
            }
        });
        this.f.setWebViewClient(new WebViewClient() { // from class: com.sigmob.sdk.base.views.q.2
            @Override // android.webkit.WebViewClient
            public void onPageFinished(WebView view, String url) {
                super.onPageFinished(view, url);
            }

            @Override // android.webkit.WebViewClient
            public void onPageStarted(WebView view, String url, Bitmap favicon) {
                super.onPageStarted(view, url, favicon);
            }

            @Override // android.webkit.WebViewClient
            public void onReceivedError(WebView view, int errorCode, String description, String failingUrl) {
                com.sigmob.sdk.base.common.ad.a("h5_error", "download_dialog", 0, failingUrl + " error:" + description, (WindAdRequest) null, (LoadAdRequest) null, q.this.g, (com.sigmob.sdk.base.common.ad.a) null);
            }

            @Override // android.webkit.WebViewClient
            public void onReceivedError(WebView view, WebResourceRequest request, WebResourceError error) {
                com.sigmob.sdk.base.utils.k.f(q.f3351a, "onReceivedError: error = " + error.toString(), new Object[0]);
                com.sigmob.sdk.base.common.ad.a("h5_error", "download_dialog", 0, request.getUrl() + " error:" + ((Object) error.getDescription()), (WindAdRequest) null, (LoadAdRequest) null, q.this.g, (com.sigmob.sdk.base.common.ad.a) null);
                super.onReceivedError(view, request, error);
            }

            @Override // android.webkit.WebViewClient
            public void onReceivedHttpError(WebView view, WebResourceRequest request, WebResourceResponse errorResponse) {
                com.sigmob.sdk.base.common.ad.a("h5_error", "download_dialog", 0, request.getUrl() + " error:" + errorResponse.getStatusCode(), (WindAdRequest) null, (LoadAdRequest) null, q.this.g, (com.sigmob.sdk.base.common.ad.a) null);
            }

            @Override // android.webkit.WebViewClient
            public void onReceivedSslError(WebView view, SslErrorHandler handler, SslError error) {
                com.sigmob.sdk.base.utils.k.f(q.f3351a, "onReceivedSslError: error = " + error.toString(), new Object[0]);
                super.onReceivedSslError(view, handler, error);
            }

            @Override // android.webkit.WebViewClient
            public WebResourceResponse shouldInterceptRequest(WebView view, WebResourceRequest request) {
                try {
                    return com.sigmob.sdk.base.l.a(request.getUrl());
                } catch (Throwable unused) {
                    return super.shouldInterceptRequest(view, request);
                }
            }

            @Override // android.webkit.WebViewClient
            public WebResourceResponse shouldInterceptRequest(WebView view, String url) {
                if (com.sigmob.sdk.base.utils.x.a(url)) {
                    return null;
                }
                try {
                    return com.sigmob.sdk.base.l.a(Uri.parse(url));
                } catch (Throwable unused) {
                    return super.shouldInterceptRequest(view, url);
                }
            }

            /* JADX WARN: Code duplicated, block: B:23:0x006f  */
            @Override // android.webkit.WebViewClient
            public boolean shouldOverrideUrlLoading(WebView view, String url) {
                byte b2;
                try {
                    SigmobLog.i(q.f3351a + "shouldOverrideUrlLoading: url = " + url);
                    Uri uri = Uri.parse(url);
                    if (StringUtil.scheme().equalsIgnoreCase(uri.getScheme())) {
                        String host = uri.getHost();
                        if (com.sigmob.sdk.base.utils.s.b(host)) {
                            int iHashCode = host.hashCode();
                            if (iHashCode != -1785504394) {
                                if (iHashCode != 986884693) {
                                    if (iHashCode == 1614272768 && host.equals("useCustomClose")) {
                                        b2 = 0;
                                    } else {
                                        b2 = -1;
                                    }
                                } else if (host.equals("closeFourElements")) {
                                    b2 = 1;
                                } else {
                                    b2 = -1;
                                }
                            } else if (host.equals("buttonClick")) {
                                b2 = 2;
                            } else {
                                b2 = -1;
                            }
                            if (b2 == 0) {
                                q.this.k = true;
                                q.this.m.removeCallbacksAndMessages(null);
                            } else if (b2 != 1) {
                                if (b2 == 2) {
                                    Map<String, String> queryParamMap = ClientMetadata.getQueryParamMap(uri);
                                    String str = queryParamMap.get("url");
                                    String str2 = queryParamMap.get("x");
                                    if (com.sigmob.sdk.base.utils.s.a((CharSequence) str2)) {
                                        str2 = "0";
                                    }
                                    String str3 = queryParamMap.get("y");
                                    if (com.sigmob.sdk.base.utils.s.a((CharSequence) str3)) {
                                        str3 = "0";
                                    }
                                    String str4 = String.format("%s,%s,%s,%s", str2, str3, str2, str3);
                                    q.this.g.getMacroCommon().updateClickMarco(str2, str3, str2, str3);
                                    q.this.g.getClickCommon().sld = "0";
                                    q.this.g.getClickCommon().down = new TouchLocation(Integer.parseInt(str2), Integer.parseInt(str3));
                                    q.this.g.getClickCommon().up = new TouchLocation(Integer.parseInt(str2), Integer.parseInt(str3));
                                    if (q.this.b != null) {
                                        q.this.b.a(str, str4);
                                    }
                                }
                            } else if (q.this.b != null) {
                                q.this.b.a();
                            }
                            return true;
                        }
                    }
                } catch (Throwable th) {
                    com.sigmob.sdk.base.utils.k.f(q.f3351a, "shouldOverrideUrlLoading: error = " + th.getMessage(), new Object[0]);
                }
                if (com.sigmob.sdk.base.utils.s.b(url) && url.startsWith("http")) {
                    view.loadUrl(url);
                }
                return true;
            }
        });
        return this.f;
    }

    public void c() {
        g gVar = this.f;
        if (gVar != null) {
            gVar.destroy();
            this.f = null;
        }
        Handler handler = this.m;
        if (handler != null) {
            handler.removeCallbacksAndMessages(null);
            this.m = null;
        }
        ImageView imageView = this.h;
        if (imageView != null) {
            com.sigmob.sdk.base.utils.w.a(imageView);
            this.h = null;
        }
        if (this.d != null) {
            this.d = null;
        }
        if (this.b != null) {
            this.b = null;
        }
    }

    @Override // android.app.Dialog
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        RelativeLayout relativeLayout = new RelativeLayout(getContext());
        this.l = relativeLayout;
        relativeLayout.setLayoutParams(new RelativeLayout.LayoutParams(-1, -1));
        Window window = getWindow();
        this.e = window;
        com.sigmob.sdk.videoplayer.c.a(window);
        this.l.setBackgroundColor(0);
        setContentView(this.l);
        setOnShowListener(this);
        setOnDismissListener(this);
        if (this.f != null) {
            this.l.addView(this.f, new RelativeLayout.LayoutParams(-1, -1));
        }
        Handler handler = new Handler(Looper.getMainLooper());
        this.m = handler;
        handler.postDelayed(new Runnable() { // from class: com.sigmob.sdk.base.views.q$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.i();
            }
        }, 5000L);
        setCanceledOnTouchOutside(true);
        setCancelable(true);
        h();
    }

    @Override // android.content.DialogInterface.OnDismissListener
    public void onDismiss(DialogInterface dialog) {
        com.sigmob.sdk.base.utils.k.b(f3351a, "onDismiss", new Object[0]);
        Activity activity = this.n;
        if (activity != null) {
            activity.setRequestedOrientation(this.o);
            this.n = null;
        }
        b bVar = this.b;
        if (bVar != null) {
            bVar.a();
        }
    }

    @Override // android.content.DialogInterface.OnShowListener
    public void onShow(DialogInterface dialog) {
        com.sigmob.sdk.base.utils.k.b(3, f3351a, "onShow", this.g, null);
        b bVar = this.b;
        if (bVar != null) {
            bVar.b();
        }
    }

    @Override // android.app.Dialog
    public void show() {
        Activity activity;
        super.show();
        Activity activityI = com.sigmob.sdk.b.i();
        this.n = activityI;
        if (com.sigmob.sdk.base.utils.v.b(activityI)) {
            this.n = com.sigmob.sdk.b.c();
        }
        if (com.sigmob.sdk.base.utils.v.b(this.n)) {
            this.o = this.n.getRequestedOrientation();
            Integer orientationInt = ClientMetadata.getInstance().getOrientationInt();
            if (com.sigmob.sdk.base.utils.v.b(orientationInt)) {
                int i = 1;
                if (orientationInt.intValue() == 1) {
                    activity = this.n;
                } else {
                    activity = this.n;
                    i = 0;
                }
                activity.setRequestedOrientation(i);
            }
        }
        e();
    }
}
