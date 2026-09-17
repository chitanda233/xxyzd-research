package com.onevcat.uniwebview;

import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.graphics.Bitmap;
import android.net.http.SslCertificate;
import android.net.http.SslError;
import android.text.method.PasswordTransformationMethod;
import android.webkit.HttpAuthHandler;
import android.webkit.RenderProcessGoneDetail;
import android.webkit.SslErrorHandler;
import android.webkit.WebResourceError;
import android.webkit.WebResourceRequest;
import android.webkit.WebResourceResponse;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.webkit.WebViewDatabase;
import android.widget.EditText;
import java.net.URI;
import java.util.LinkedHashMap;
import java.util.LinkedHashSet;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: loaded from: classes3.dex */
public final class J extends WebViewClient {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Context f2838a;
    public final V1 b;
    public boolean c;
    public boolean d;
    public boolean e;
    public int f;
    public final LinkedHashMap g;
    public final C0672r h;
    public final LinkedHashSet i;
    public boolean j;

    public J(Context context, InterfaceC0675s responderDelegate, V1 loadingObserver) {
        Intrinsics.checkNotNullParameter(context, "context");
        Intrinsics.checkNotNullParameter(responderDelegate, "responderDelegate");
        Intrinsics.checkNotNullParameter(loadingObserver, "loadingObserver");
        this.f2838a = context;
        this.b = loadingObserver;
        this.d = true;
        this.f = 200;
        this.g = new LinkedHashMap();
        this.h = new C0672r(context, responderDelegate);
        this.i = new LinkedHashSet();
        this.j = true;
    }

    public final void a(final WebView webView, final HttpAuthHandler httpAuthHandler, final String str, final String str2) {
        final EditText editText = new EditText(this.f2838a);
        editText.setHint(this.f2838a.getResources().getString(R.string.USERNAME));
        final EditText editText2 = new EditText(this.f2838a);
        editText2.setHint(this.f2838a.getResources().getString(R.string.PASSWORD));
        editText2.setTransformationMethod(PasswordTransformationMethod.getInstance());
        AlertDialog.Builder message = new AlertDialog.Builder(this.f2838a).setTitle(this.f2838a.getResources().getString(R.string.AUTH_REQUIRE_TITLE)).setMessage(str);
        Intrinsics.checkNotNullExpressionValue(message, "Builder(context)\n       …        .setMessage(host)");
        AbstractC0621a.a(message, editText, editText2).setCancelable(false).setPositiveButton(this.f2838a.getString(android.R.string.ok), new DialogInterface.OnClickListener() { // from class: com.onevcat.uniwebview.J$$ExternalSyntheticLambda0
            @Override // android.content.DialogInterface.OnClickListener
            public final void onClick(DialogInterface dialogInterface, int i) {
                J.a(editText, editText2, this, str, str2, webView, httpAuthHandler, dialogInterface, i);
            }
        }).setNegativeButton(this.f2838a.getString(android.R.string.cancel), new DialogInterface.OnClickListener() { // from class: com.onevcat.uniwebview.J$$ExternalSyntheticLambda1
            @Override // android.content.DialogInterface.OnClickListener
            public final void onClick(DialogInterface dialogInterface, int i) {
                J.a(httpAuthHandler, dialogInterface, i);
            }
        }).create().show();
    }

    @Override // android.webkit.WebViewClient
    public final void onPageFinished(WebView webView, String str) {
        super.onPageFinished(webView, str);
        if (this.d) {
            if (this.e) {
                C0654l c0654l = C0654l.b;
                String message = "WebClient onReceivedError for url: " + str + ", Error Code: -1202, Error: SSL error";
                c0654l.getClass();
                Intrinsics.checkNotNullParameter(message, "message");
                c0654l.a(EnumC0651k.CRITICAL, message);
                this.b.a(X1.a(str, -1202, "SSL error"));
                return;
            }
            if (!this.c) {
                C0654l c0654l2 = C0654l.b;
                String message2 = "WebClient onPageFinished: " + str + ", HTTP Status Code: " + this.f;
                c0654l2.getClass();
                Intrinsics.checkNotNullParameter(message2, "message");
                c0654l2.a(EnumC0651k.INFO, message2);
                this.b.a(str, this.f);
                return;
            }
            C0654l c0654l3 = C0654l.b;
            String message3 = "WebClient onReceivedError for url: " + str + ", Error Code: -999, Error: Operation cancelled";
            c0654l3.getClass();
            Intrinsics.checkNotNullParameter(message3, "message");
            c0654l3.a(EnumC0651k.INFO, message3);
            this.b.a(X1.a(str, -999, "Operation cancelled"));
        }
    }

    @Override // android.webkit.WebViewClient
    public final void onPageStarted(WebView webView, String str, Bitmap bitmap) {
        super.onPageStarted(webView, str, bitmap);
        C0654l c0654l = C0654l.b;
        c0654l.a(EnumC0651k.INFO, AbstractC0669q.a("WebClient onPageStarted: ", str, c0654l, "message"));
        this.b.a(str);
    }

    @Override // android.webkit.WebViewClient
    public final void onReceivedError(WebView webView, int i, String str, String str2) {
    }

    @Override // android.webkit.WebViewClient
    public final void onReceivedHttpAuthRequest(WebView webView, HttpAuthHandler httpAuthHandler, String str, String str2) {
        String str3;
        String str4;
        String[] httpAuthUsernamePassword;
        if (httpAuthHandler == null) {
            return;
        }
        if (!httpAuthHandler.useHttpAuthUsernamePassword() || webView == null || (httpAuthUsernamePassword = WebViewDatabase.getInstance(this.f2838a).getHttpAuthUsernamePassword(str, str2)) == null || httpAuthUsernamePassword.length != 2) {
            str3 = null;
            str4 = null;
        } else {
            str3 = httpAuthUsernamePassword[0];
            str4 = httpAuthUsernamePassword[1];
        }
        if (str3 != null && str4 != null) {
            httpAuthHandler.proceed(str3, str4);
        } else if (this.j) {
            a(webView, httpAuthHandler, str, str2);
        } else {
            httpAuthHandler.cancel();
        }
    }

    @Override // android.webkit.WebViewClient
    public final void onReceivedHttpError(WebView webView, WebResourceRequest webResourceRequest, WebResourceResponse webResourceResponse) {
        super.onReceivedHttpError(webView, webResourceRequest, webResourceResponse);
        C0654l c0654l = C0654l.b;
        C0654l c0654l2 = C0654l.b;
        String message = "WebClient onReceivedHttpError. Error Code: " + (webResourceResponse != null ? Integer.valueOf(webResourceResponse.getStatusCode()) : null) + ", url: " + webResourceRequest + "?.url";
        c0654l2.getClass();
        Intrinsics.checkNotNullParameter(message, "message");
        c0654l2.a(EnumC0651k.INFO, message);
        if (webResourceResponse == null || webResourceRequest == null || !webResourceRequest.isForMainFrame()) {
            return;
        }
        this.f = webResourceResponse.getStatusCode();
    }

    @Override // android.webkit.WebViewClient
    public final void onReceivedSslError(WebView webView, SslErrorHandler sslErrorHandler, SslError sslError) {
        C0654l c0654l = C0654l.b;
        String message = "WebClient onReceivedSslError. Error url: " + (sslError != null ? sslError.getUrl() : null) + ", Error type: " + (sslError != null ? Integer.valueOf(sslError.getPrimaryError()) : null);
        c0654l.getClass();
        Intrinsics.checkNotNullParameter(message, "message");
        EnumC0651k enumC0651k = EnumC0651k.CRITICAL;
        c0654l.a(enumC0651k, message);
        if (sslError == null) {
            Intrinsics.checkNotNullParameter("Receiving SSL error callback with `null` error. This should not happen.", "message");
            c0654l.a(enumC0651k, "Receiving SSL error callback with `null` error. This should not happen.");
            this.e = true;
            if (sslErrorHandler != null) {
                sslErrorHandler.cancel();
                return;
            }
            return;
        }
        Intrinsics.checkNotNullParameter("Trying to process SSL error...", "message");
        EnumC0651k enumC0651k2 = EnumC0651k.VERBOSE;
        c0654l.a(enumC0651k2, "Trying to process SSL error...");
        try {
            String host = new URI(sslError.getUrl()).getHost();
            SslCertificate certificate = sslError.getCertificate();
            if (certificate.getIssuedBy() != null && certificate.getIssuedTo() != null) {
                if (this.i.contains(host)) {
                    String message2 = "Found domain '" + host + "' in exception list. Processing url.";
                    Intrinsics.checkNotNullParameter(message2, "message");
                    c0654l.a(enumC0651k2, message2);
                    if (sslErrorHandler != null) {
                        sslErrorHandler.proceed();
                        return;
                    }
                    return;
                }
                String message3 = "Domain '" + host + "' is not in exception list. Refuse proceeding url.";
                Intrinsics.checkNotNullParameter(message3, "message");
                c0654l.a(enumC0651k2, message3);
                this.e = true;
                if (sslErrorHandler != null) {
                    sslErrorHandler.cancel();
                    return;
                }
                return;
            }
            Intrinsics.checkNotNullParameter("Cannot get correct certificate issuer. SSL challenge failed.", "message");
            c0654l.a(enumC0651k2, "Cannot get correct certificate issuer. SSL challenge failed.");
            this.e = true;
            if (sslErrorHandler != null) {
                sslErrorHandler.cancel();
            }
        } catch (Exception e) {
            C0654l c0654l2 = C0654l.b;
            String message4 = "Exception during handling SSL error: " + e;
            c0654l2.getClass();
            Intrinsics.checkNotNullParameter(message4, "message");
            c0654l2.a(EnumC0651k.CRITICAL, message4);
            if (sslErrorHandler != null) {
                sslErrorHandler.cancel();
            }
        }
    }

    @Override // android.webkit.WebViewClient
    public final boolean onRenderProcessGone(WebView webView, RenderProcessGoneDetail renderProcessGoneDetail) {
        C0654l c0654l;
        String message;
        if (renderProcessGoneDetail == null) {
            c0654l = C0654l.b;
            message = "onRenderProcessGone is triggered. Detail: null";
        } else {
            c0654l = C0654l.b;
            message = "onRenderProcessGone is triggered. didCrash: " + renderProcessGoneDetail.didCrash() + ", priority: " + renderProcessGoneDetail.rendererPriorityAtExit();
        }
        c0654l.getClass();
        Intrinsics.checkNotNullParameter(message, "message");
        c0654l.a(EnumC0651k.CRITICAL, message);
        this.b.a();
        return true;
    }

    @Override // android.webkit.WebViewClient
    public final boolean shouldOverrideUrlLoading(WebView webView, String str) {
        if (str == null) {
            return false;
        }
        if (this.h.a(str, false, webView instanceof C0687w ? ((C0687w) webView).getName() : null)) {
            return true;
        }
        this.f = 200;
        this.d = true;
        this.c = false;
        this.e = false;
        if (!(!this.g.isEmpty())) {
            return false;
        }
        C0654l c0654l = C0654l.b;
        String message = "Adding customize header to request. " + this.g;
        c0654l.getClass();
        Intrinsics.checkNotNullParameter(message, "message");
        c0654l.a(EnumC0651k.DEBUG, message);
        if (webView != null) {
            webView.loadUrl(str, this.g);
        }
        return true;
    }

    public static final void a(EditText userText, EditText passwordText, J this$0, String str, String str2, WebView webView, HttpAuthHandler handler, DialogInterface dialogInterface, int i) {
        Intrinsics.checkNotNullParameter(userText, "$userText");
        Intrinsics.checkNotNullParameter(passwordText, "$passwordText");
        Intrinsics.checkNotNullParameter(this$0, "this$0");
        Intrinsics.checkNotNullParameter(handler, "$handler");
        String string = userText.getText().toString();
        String string2 = passwordText.getText().toString();
        WebViewDatabase.getInstance(this$0.f2838a).setHttpAuthUsernamePassword(str, str2, string, string2);
        handler.proceed(string, string2);
    }

    public static final void a(HttpAuthHandler handler, DialogInterface dialogInterface, int i) {
        Intrinsics.checkNotNullParameter(handler, "$handler");
        handler.cancel();
    }

    @Override // android.webkit.WebViewClient
    public final void onReceivedError(WebView webView, WebResourceRequest webResourceRequest, WebResourceError webResourceError) {
        super.onReceivedError(webView, webResourceRequest, webResourceError);
        C0654l c0654l = C0654l.b;
        String message = "WebClient onReceivedError. Request: " + webResourceRequest + "; Error: " + webResourceError;
        c0654l.getClass();
        Intrinsics.checkNotNullParameter(message, "message");
        EnumC0651k enumC0651k = EnumC0651k.INFO;
        c0654l.a(enumC0651k, message);
        if (webResourceRequest != null) {
            String message2 = "WebClient request detail: " + webResourceRequest.getUrl();
            Intrinsics.checkNotNullParameter(message2, "message");
            c0654l.a(enumC0651k, message2);
        }
        if (webResourceError != null) {
            String message3 = "WebClient error detail: " + ((Object) webResourceError.getDescription());
            Intrinsics.checkNotNullParameter(message3, "message");
            c0654l.a(enumC0651k, message3);
        }
        if (webResourceError == null || webResourceRequest == null || !webResourceRequest.isForMainFrame()) {
            return;
        }
        this.d = false;
        this.b.a(X1.a(webResourceRequest.getUrl().toString(), webResourceError.getErrorCode(), webResourceError.getDescription().toString()));
    }
}
