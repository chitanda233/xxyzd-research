package com.sigmob.sdk.base.views;

import android.text.TextUtils;
import com.czhj.sdk.common.utils.Preconditions;
import com.czhj.sdk.logger.SigmobLog;
import java.io.Serializable;
import java.util.Arrays;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class n implements Serializable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final List<String> f3344a = Arrays.asList("image/jpeg", "image/png", "image/bmp", "image/gif");
    private static final List<String> b = Arrays.asList("application/x-javascript");
    private static final long serialVersionUID = 0;
    private final String c;
    private final b d;
    private final a e;
    private final int f;
    private final int g;

    /* JADX INFO: renamed from: com.sigmob.sdk.base.views.n$1, reason: invalid class name */
    static /* synthetic */ class AnonymousClass1 {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f3345a;

        static {
            int[] iArr = new int[b.values().length];
            f3345a = iArr;
            try {
                iArr[b.IFRAME_RESOURCE.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                f3345a[b.HTML_RESOURCE.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                f3345a[b.STATIC_RESOURCE.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            try {
                f3345a[b.NATIVE_RESOURCE.ordinal()] = 4;
            } catch (NoSuchFieldError unused4) {
            }
            try {
                f3345a[b.URL_RESOURCE.ordinal()] = 5;
            } catch (NoSuchFieldError unused5) {
            }
        }
    }

    public enum a {
        NONE,
        IMAGE,
        JAVASCRIPT
    }

    public enum b {
        STATIC_RESOURCE,
        HTML_RESOURCE,
        IFRAME_RESOURCE,
        NATIVE_RESOURCE,
        URL_RESOURCE
    }

    public n(String resource, b type, a creativeType, int width, int height) {
        Preconditions.NoThrow.checkNotNull(resource);
        Preconditions.NoThrow.checkNotNull(type);
        Preconditions.NoThrow.checkNotNull(creativeType);
        this.c = resource;
        this.d = type;
        this.e = creativeType;
        this.f = width;
        this.g = height;
    }

    public String a() {
        return this.c;
    }

    /* JADX WARN: Code duplicated, block: B:24:0x003b  */
    /* JADX WARN: Code duplicated, block: B:26:0x0041  */
    /* JADX WARN: Code duplicated, block: B:28:0x004a A[RETURN] */
    /* JADX WARN: Code duplicated, block: B:29:0x004b A[RETURN] */
    /* JADX WARN: Code duplicated, block: B:30:0x004c  */
    /* JADX WARN: Code duplicated, block: B:32:0x0052  */
    public String a(String clickThroughUrl, String webViewClickThroughUrl) {
        int i = AnonymousClass1.f3345a[this.d.ordinal()];
        if (i == 1 || i == 2) {
            if (a.IMAGE == this.e) {
                SigmobLog.d("CreativeType.IMAGE");
                if (TextUtils.isEmpty(webViewClickThroughUrl)) {
                    return clickThroughUrl;
                }
                return null;
            }
            if (a.JAVASCRIPT == this.e) {
                SigmobLog.d("CreativeType.JAVASCRIPT");
                return webViewClickThroughUrl;
            }
        } else {
            if (i == 3) {
                if (a.IMAGE == this.e) {
                    SigmobLog.d("CreativeType.IMAGE");
                    return TextUtils.isEmpty(clickThroughUrl) ? webViewClickThroughUrl : clickThroughUrl;
                }
                if (a.JAVASCRIPT != this.e) {
                    return null;
                }
                SigmobLog.d("CreativeType.JAVASCRIPT");
                return webViewClickThroughUrl;
            }
            if (i == 4 || i == 5) {
                if (a.IMAGE == this.e) {
                    SigmobLog.d("CreativeType.IMAGE");
                    if (TextUtils.isEmpty(webViewClickThroughUrl)) {
                        return clickThroughUrl;
                    }
                    return null;
                }
                if (a.JAVASCRIPT == this.e) {
                    SigmobLog.d("CreativeType.JAVASCRIPT");
                    return webViewClickThroughUrl;
                }
            }
        }
        return null;
    }

    public void a(o webView) {
        StringBuilder sbAppend;
        String str;
        String string;
        String str2;
        Preconditions.NoThrow.checkNotNull(webView);
        int i = AnonymousClass1.f3345a[this.d.ordinal()];
        if (i != 1) {
            if (i == 2) {
                string = this.c;
            } else {
                if (i != 3) {
                    if (i == 4) {
                        if (!this.c.toLowerCase().startsWith("file://")) {
                            str2 = "file://" + this.c;
                        }
                        webView.loadUrl(str2);
                        return;
                    } else if (i != 5) {
                        return;
                    }
                    str2 = this.c;
                    webView.loadUrl(str2);
                    return;
                }
                if (this.e == a.IMAGE) {
                    sbAppend = new StringBuilder("<html><head></head><body style=\"margin:0;padding:0\"><img src=\"").append(this.c);
                    str = "\" width=\"100%\" style=\"max-width:100%;max-height:100%;\" /></body></html>";
                } else {
                    if (this.e != a.JAVASCRIPT) {
                        return;
                    }
                    sbAppend = new StringBuilder("<script src=\"").append(this.c);
                    str = "\"></script>";
                }
            }
            webView.a(string);
        }
        sbAppend = new StringBuilder("<iframe frameborder=\"0\" scrolling=\"no\" marginheight=\"0\" marginwidth=\"0\" style=\"border: 0px; margin: 0px;\" width=\"").append(this.f).append("\" height=\"").append(this.g).append("\" src=\"").append(this.c);
        str = "\"></iframe>";
        string = sbAppend.append(str).toString();
        webView.a(string);
    }

    public b b() {
        return this.d;
    }

    public a c() {
        return this.e;
    }
}
