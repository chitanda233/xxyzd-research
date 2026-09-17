package com.sigmob.sdk.videoAd;

import android.animation.ValueAnimator;
import android.app.Activity;
import android.app.Dialog;
import android.content.Context;
import android.content.Intent;
import android.content.res.Configuration;
import android.graphics.Bitmap;
import android.graphics.Color;
import android.media.MediaMetadataRetriever;
import android.net.Uri;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.util.Base64;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewParent;
import android.view.animation.LinearInterpolator;
import android.view.animation.RotateAnimation;
import android.webkit.DownloadListener;
import android.webkit.JavascriptInterface;
import android.webkit.WebResourceError;
import android.webkit.WebResourceRequest;
import android.webkit.WebView;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import androidx.core.app.NotificationCompat;
import com.byazt.bv.BaseConstants;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.common.utils.Preconditions;
import com.czhj.sdk.common.utils.ResourceUtil;
import com.czhj.sdk.common.utils.ViewUtil;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.volley.toolbox.ImageLoader;
import com.czhj.volley.toolbox.StringUtil;
import com.google.android.gms.common.util.GmsVersion;
import com.sigmob.sdk.base.common.ac;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.common.am;
import com.sigmob.sdk.base.common.n;
import com.sigmob.sdk.base.common.v;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.ClickCommon;
import com.sigmob.sdk.base.models.IntentActions;
import com.sigmob.sdk.base.models.SensorEntity;
import com.sigmob.sdk.base.models.SigMacroCommon;
import com.sigmob.sdk.base.models.rtb.ClickAreaSetting;
import com.sigmob.sdk.base.models.rtb.CompanionEndcard;
import com.sigmob.sdk.base.models.rtb.LinkAction;
import com.sigmob.sdk.base.models.rtb.MaterialMeta;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.sdk.base.views.ap;
import com.sigmob.sdk.base.views.ar;
import com.sigmob.sdk.base.views.as;
import com.sigmob.sdk.base.views.aw;
import com.sigmob.sdk.base.views.o;
import com.sigmob.sdk.base.views.q;
import com.sigmob.sdk.base.views.r;
import com.sigmob.sdk.base.views.w;
import com.sigmob.sdk.base.views.z;
import com.sigmob.windad.natives.WindNativeAdData;
import java.io.File;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Locale;
import java.util.Map;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public class j extends b implements ac, com.sigmob.sdk.base.common.h.a, com.sigmob.sdk.videocache.d {
    public static final String f = "j";
    static final String g = "video_config";
    private static final String i = "current_position";
    private static final String j = "video_finished";
    private static final String k = "companionAd_visable";
    private static final long l = 50;
    private static final int m = -1;
    private static final int n = 0;
    private static int o;
    private String A;
    private boolean B;
    private final Handler C;
    private boolean D;
    private com.sigmob.sdk.base.views.d E;
    private String F;
    private int G;
    private boolean H;
    private com.sigmob.sdk.videoAd.a I;
    private int J;
    private com.sigmob.sdk.videoplayer.a K;
    private BaseAdUnit L;
    private View M;
    private v N;
    private final MediaMetadataRetriever O;
    private as P;
    private ar Q;
    private w R;
    private f S;
    private int T;
    private int U;
    private boolean V;
    private boolean W;
    private int X;
    private boolean Y;
    private RelativeLayout Z;
    private boolean aa;
    private ar ab;
    private boolean ac;
    private boolean ad;
    private ImageLoader.ImageContainer ae;
    private com.sigmob.sdk.base.views.m af;
    private boolean ag;
    private boolean ah;
    private z ai;
    private boolean aj;
    private q ak;
    private boolean al;
    private w am;
    private w an;
    private am.a ao;
    private com.sigmob.sdk.base.views.v ap;
    private boolean aq;
    private com.sigmob.sdk.nativead.b ar;
    private w as;
    private boolean at;
    private boolean au;
    private boolean av;
    private boolean aw;
    private String ax;
    private final View.OnClickListener ay;
    private boolean az;
    String h;
    private final int p;
    private com.sigmob.sdk.base.views.b q;
    private ImageView r;
    private RelativeLayout s;
    private int t;
    private boolean u;
    private int v;
    private String w;
    private final List<String> x;
    private final List<String> y;
    private long z;

    /* JADX INFO: renamed from: com.sigmob.sdk.videoAd.j$10, reason: invalid class name */
    class AnonymousClass10 extends am.b {
        AnonymousClass10() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b() {
            j.this.J();
        }

        @Override // com.sigmob.sdk.base.common.am.b, com.sigmob.sdk.base.common.am.c
        public void a(Map<String, Number> info) {
            if (info == null || j.this.L == null || j.this.aq) {
                return;
            }
            j.this.aq = true;
            Number number = info.get("x_max_acc");
            Number number2 = info.get("y_max_acc");
            Number number3 = info.get("z_max_acc");
            ClickCommon clickCommon = j.this.L.getClickCommon();
            if (number != null) {
                clickCommon.x_max_acc = String.valueOf(number.intValue());
            }
            if (number2 != null) {
                clickCommon.y_max_acc = String.valueOf(number2.intValue());
            }
            if (number3 != null) {
                clickCommon.z_max_acc = String.valueOf(number3.intValue());
            }
            clickCommon.sld = "2";
            j.this.ap.postDelayed(new Runnable() { // from class: com.sigmob.sdk.videoAd.j$10$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.b();
                }
            }, 400L);
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.videoAd.j$11, reason: invalid class name */
    class AnonymousClass11 extends am.b {
        AnonymousClass11() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b() {
            j.this.J();
        }

        @Override // com.sigmob.sdk.base.common.am.b, com.sigmob.sdk.base.common.am.c
        public void a(Map<String, Number> info) {
            if (info == null || j.this.L == null || j.this.aq) {
                return;
            }
            j.this.aq = true;
            Number number = info.get("turn_x");
            Number number2 = info.get("turn_y");
            Number number3 = info.get("turn_z");
            Number number4 = info.get("turn_time");
            ClickCommon clickCommon = j.this.L.getClickCommon();
            if (number != null) {
                clickCommon.turn_x = String.valueOf(number.intValue());
            }
            if (number2 != null) {
                clickCommon.turn_y = String.valueOf(number2.intValue());
            }
            if (number3 != null) {
                clickCommon.turn_z = String.valueOf(number3.intValue());
            }
            clickCommon.turn_time = String.valueOf(number4);
            clickCommon.sld = "5";
            j.this.ap.postDelayed(new Runnable() { // from class: com.sigmob.sdk.videoAd.j$11$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.b();
                }
            }, 400L);
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.videoAd.j$12, reason: invalid class name */
    class AnonymousClass12 extends am.b {
        AnonymousClass12() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b() {
            j.this.J();
        }

        @Override // com.sigmob.sdk.base.common.am.b, com.sigmob.sdk.base.common.am.c
        public void a(float progress) {
            if (j.this.ap instanceof ap) {
                ((ap) j.this.ap).a(progress);
            }
        }

        @Override // com.sigmob.sdk.base.common.am.b, com.sigmob.sdk.base.common.am.c
        public void a(Map<String, Number> info) {
            if (info == null || j.this.L == null || j.this.aq) {
                return;
            }
            j.this.aq = true;
            Number number = info.get("x_max_acc");
            Number number2 = info.get("y_max_acc");
            Number number3 = info.get("z_max_acc");
            ClickCommon clickCommon = j.this.L.getClickCommon();
            if (number != null) {
                clickCommon.x_max_acc = String.valueOf(number.intValue());
            }
            if (number2 != null) {
                clickCommon.y_max_acc = String.valueOf(number2.intValue());
            }
            if (number3 != null) {
                clickCommon.z_max_acc = String.valueOf(number3.intValue());
            }
            clickCommon.sld = "2";
            j.this.ap.postDelayed(new Runnable() { // from class: com.sigmob.sdk.videoAd.j$12$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.b();
                }
            }, 400L);
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.videoAd.j$13, reason: invalid class name */
    class AnonymousClass13 extends am.b {
        AnonymousClass13() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b() {
            j.this.J();
        }

        @Override // com.sigmob.sdk.base.common.am.b, com.sigmob.sdk.base.common.am.c
        public void a(float progress) {
            if (j.this.ap instanceof com.sigmob.sdk.base.views.am) {
                ((com.sigmob.sdk.base.views.am) j.this.ap).a(progress);
            }
        }

        @Override // com.sigmob.sdk.base.common.am.b, com.sigmob.sdk.base.common.am.c
        public void a(Map<String, Number> info) {
            if (info == null || j.this.L == null || j.this.aq) {
                return;
            }
            j.this.aq = true;
            Number number = info.get("turn_x");
            Number number2 = info.get("turn_y");
            Number number3 = info.get("turn_z");
            Number number4 = info.get("turn_time");
            ClickCommon clickCommon = j.this.L.getClickCommon();
            if (number != null) {
                clickCommon.turn_x = String.valueOf(number.intValue());
            }
            if (number2 != null) {
                clickCommon.turn_y = String.valueOf(number2.intValue());
            }
            if (number3 != null) {
                clickCommon.turn_z = String.valueOf(number3.intValue());
            }
            clickCommon.turn_time = String.valueOf(number4);
            clickCommon.sld = "5";
            j.this.ap.postDelayed(new Runnable() { // from class: com.sigmob.sdk.videoAd.j$13$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.b();
                }
            }, 400L);
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.videoAd.j$6, reason: invalid class name */
    class AnonymousClass6 extends com.sigmob.sdk.base.l {
        AnonymousClass6() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void a(String str, Object obj) {
            if (obj instanceof PointEntitySigmob) {
                ((PointEntitySigmob) obj).setUrl(str);
            }
        }

        @Override // android.webkit.WebViewClient
        public void onPageFinished(WebView view, String url) {
            super.onPageFinished(view, url);
            SigmobLog.d("onPageFinished: ");
            j.this.w = "done";
        }

        @Override // android.webkit.WebViewClient
        public void onPageStarted(WebView view, String url, Bitmap favicon) {
            super.onPageStarted(view, url, favicon);
            SigmobLog.d("onPageStarted: ");
        }

        @Override // android.webkit.WebViewClient
        public void onReceivedError(WebView view, int errorCode, String description, String failingUrl) {
            super.onReceivedError(view, errorCode, description, failingUrl);
            if (failingUrl.startsWith("http://")) {
                return;
            }
            j.this.w = "error";
        }

        @Override // android.webkit.WebViewClient
        public void onReceivedError(WebView view, WebResourceRequest request, WebResourceError error) {
            super.onReceivedError(view, request, error);
            String host = request.getUrl().getHost();
            if (s.a((CharSequence) host) || !host.equals("localhost")) {
                return;
            }
            j.this.w = "error";
        }

        @Override // android.webkit.WebViewClient
        public boolean shouldOverrideUrlLoading(WebView view, String url) {
            try {
                SigmobLog.d("load url " + url);
                Uri uri = Uri.parse(url);
                String host = uri.getHost();
                String scheme = uri.getScheme();
                if (!s.a((CharSequence) host)) {
                    if (!"track".equals(host) && !"active".equals(host)) {
                        if ("openFourElements".equals(host)) {
                            j.this.b(2);
                            return true;
                        }
                    }
                    String queryParameter = uri.getQueryParameter("data");
                    String queryParameter2 = uri.getQueryParameter(NotificationCompat.CATEGORY_EVENT);
                    if (!s.a((CharSequence) queryParameter2) && !s.a((CharSequence) queryParameter)) {
                        final String str = new String(Base64.decode(queryParameter, 0), "utf-8");
                        ad.a(host, queryParameter2, j.this.L, new ad.a() { // from class: com.sigmob.sdk.videoAd.j$6$$ExternalSyntheticLambda0
                            @Override // com.sigmob.sdk.base.common.ad.a
                            public final void onAddExtra(Object obj) {
                                j.AnonymousClass6.a(str, obj);
                            }
                        });
                    }
                    return true;
                }
                if (j.this.aa) {
                    return true;
                }
                if (j.this.L.getMaterial().disable_auto_deeplink.booleanValue() && !j.this.B) {
                    return (s.b(scheme) && scheme.startsWith("http")) ? false : true;
                }
                if (j.this.L.getMaterial().click_type.intValue() == com.sigmob.sdk.base.common.m.Button.a() || s.a((CharSequence) j.this.L.getLanding_page()) || j.this.L.getMaterial().creative_type.intValue() == n.CreativeTypeVideo_EndCardURL.a()) {
                    j.this.L.getClickCommon().click_area = ClickCommon.CLICK_AREA_BTN;
                    j.this.L.getClickCommon().click_scene = "endcard";
                    if (j.this.Q.getVisibility() != 0 || s.a((CharSequence) scheme)) {
                        if (!s.a((CharSequence) scheme) && (scheme.equals("http") || scheme.equals("https"))) {
                            if (j.this.ah) {
                                j.this.W();
                                j.this.ah = false;
                            }
                            view.loadUrl(url);
                        }
                    } else if (!StringUtil.scheme().equalsIgnoreCase(scheme) || s.a((CharSequence) host) || !host.equalsIgnoreCase("download") || s.a((CharSequence) j.this.L.getMaterial().landing_page)) {
                        try {
                            LinkAction linkActionA = com.sigmob.sdk.videoplayer.c.a(j.this.L.getAdLinkActions(), uri);
                            if (linkActionA == null) {
                                linkActionA = com.sigmob.sdk.videoplayer.c.a(j.this.L.getSlotAdLinkActions(), uri);
                            }
                            boolean zHasReachedMaxRedirectCount = j.this.L.hasReachedMaxRedirectCount();
                            int quickAppMaxRedirectCount = j.this.L.getQuickAppMaxRedirectCount();
                            if (zHasReachedMaxRedirectCount) {
                                com.sigmob.sdk.base.utils.k.e(j.f, "reach max redirect count(%d).", Integer.valueOf(quickAppMaxRedirectCount));
                                return true;
                            }
                            int redirectCount = j.this.L.getRedirectCount(uri);
                            if (linkActionA != null && linkActionA.redirect_count.intValue() <= redirectCount) {
                                com.sigmob.sdk.base.utils.k.e(j.f, "%s reach redirect count(%d).", scheme, Integer.valueOf(redirectCount));
                                return true;
                            }
                            if (!scheme.equalsIgnoreCase("http") && !scheme.equalsIgnoreCase("https")) {
                                j.this.L.addRedirectCount(uri);
                                j.this.L.setCustomDeeplink(url);
                                j.this.L.incrementRedirectCount();
                                j.this.I.a(com.sigmob.sdk.base.a.ENDCARD, j.this.h, true);
                                com.sigmob.sdk.base.utils.k.c(j.f, "%s(quick) not reach redirect count(%d).", scheme, Integer.valueOf(redirectCount));
                                return true;
                            }
                            view.loadUrl(url);
                            com.sigmob.sdk.base.utils.k.c(j.f, "%s(302) not reach redirect count(%d).", scheme, Integer.valueOf(redirectCount));
                        } catch (Exception e) {
                            e.printStackTrace();
                        }
                    } else {
                        j.this.I.a(com.sigmob.sdk.base.a.ENDCARD, j.this.h, true);
                    }
                } else if (j.this.L.getMaterial().click_type.intValue() == com.sigmob.sdk.base.common.m.FullScreen.a()) {
                    s.a((CharSequence) j.this.L.getLanding_page());
                    return true;
                }
            } catch (Throwable unused) {
                SigmobLog.e("webview");
            }
            return true;
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.videoAd.j$7, reason: invalid class name */
    static /* synthetic */ class AnonymousClass7 {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f3649a;
        static final /* synthetic */ int[] b;

        static {
            int[] iArr = new int[com.sigmob.sdk.base.a.values().length];
            b = iArr;
            try {
                iArr[com.sigmob.sdk.base.a.COMPANION.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                b[com.sigmob.sdk.base.a.VIDEO_CLICK.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                b[com.sigmob.sdk.base.a.MOTION.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            int[] iArr2 = new int[com.sigmob.sdk.videoplayer.d.values().length];
            f3649a = iArr2;
            try {
                iArr2[com.sigmob.sdk.videoplayer.d.STATE_PREPARED.ordinal()] = 1;
            } catch (NoSuchFieldError unused4) {
            }
            try {
                f3649a[com.sigmob.sdk.videoplayer.d.STATE_PLAYING.ordinal()] = 2;
            } catch (NoSuchFieldError unused5) {
            }
            try {
                f3649a[com.sigmob.sdk.videoplayer.d.STATE_AUTO_COMPLETE.ordinal()] = 3;
            } catch (NoSuchFieldError unused6) {
            }
            try {
                f3649a[com.sigmob.sdk.videoplayer.d.STATE_STOP.ordinal()] = 4;
            } catch (NoSuchFieldError unused7) {
            }
            try {
                f3649a[com.sigmob.sdk.videoplayer.d.STATE_BUFFERING_START.ordinal()] = 5;
            } catch (NoSuchFieldError unused8) {
            }
            try {
                f3649a[com.sigmob.sdk.videoplayer.d.STATE_BUFFERING_END.ordinal()] = 6;
            } catch (NoSuchFieldError unused9) {
            }
            try {
                f3649a[com.sigmob.sdk.videoplayer.d.STATE_PAUSE.ordinal()] = 7;
            } catch (NoSuchFieldError unused10) {
            }
            try {
                f3649a[com.sigmob.sdk.videoplayer.d.STATE_ERROR.ordinal()] = 8;
            } catch (NoSuchFieldError unused11) {
            }
        }
    }

    static class a {
        a() {
        }

        @JavascriptInterface
        public int getInteractionType() {
            return j.o;
        }

        @JavascriptInterface
        public String getSdkVersion() {
            return "4.25.14";
        }
    }

    public j(Activity activity, BaseAdUnit adUnit, Bundle intentExtras, Bundle savedInstanceState, String uuid, com.sigmob.sdk.base.common.k controllerListener) throws IllegalStateException {
        super(activity, uuid, controllerListener);
        this.t = 0;
        this.u = false;
        this.v = 0;
        this.w = "undone";
        this.x = new ArrayList();
        this.y = new ArrayList();
        this.A = "none";
        this.C = new Handler(Looper.getMainLooper());
        this.D = true;
        this.L = null;
        this.O = new MediaMetadataRetriever();
        this.T = 0;
        this.Y = false;
        this.aa = false;
        this.ac = false;
        this.ad = false;
        this.ag = false;
        this.aj = false;
        this.al = false;
        this.ay = new View.OnClickListener() { // from class: com.sigmob.sdk.videoAd.j.9
            @Override // android.view.View.OnClickListener
            public void onClick(View view) {
                Activity activityN = j.this.n();
                if (activityN == null || j.this.L == null) {
                    return;
                }
                j jVar = j.this;
                if (jVar.a((Dialog) jVar.ar)) {
                    return;
                }
                j.this.ar = new com.sigmob.sdk.nativead.b(activityN, j.this.L);
                j.this.ar.a();
                j.this.ar.a(new WindNativeAdData.DislikeInteractionCallback() { // from class: com.sigmob.sdk.videoAd.j.9.1
                    @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                    public void onCancel() {
                        j.this.N();
                        j.this.G();
                        if (j.this.ao == null) {
                            return;
                        }
                        j.this.ao.a();
                    }

                    @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                    public void onSelected(int position, String value, boolean enforce) {
                        j.this.N();
                        j.this.G();
                        if (j.this.ao == null) {
                            return;
                        }
                        j.this.ao.a();
                    }

                    @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
                    public void onShow() {
                        j.this.O();
                        if (j.this.ao == null) {
                            return;
                        }
                        j.this.ao.b();
                    }
                });
            }
        };
        this.L = adUnit;
        this.I = (com.sigmob.sdk.videoAd.a) adUnit.getAdConfig();
        this.p = Dips.dipsToIntPixels(10.0f, this.f3184a);
        this.I.a(n(), this.L, new q.b() { // from class: com.sigmob.sdk.videoAd.j.1
            @Override // com.sigmob.sdk.base.views.q.b
            public void a() {
                j.this.al = false;
                j.this.aq = false;
                j.this.N();
                if (j.this.ao != null) {
                    j.this.ao.a();
                }
            }

            @Override // com.sigmob.sdk.base.views.q.b
            public void a(Error error) {
            }

            @Override // com.sigmob.sdk.base.views.q.b
            public void a(String url, String clickCoordinate) {
                ClickCommon clickCommon = j.this.L.getClickCommon();
                clickCommon.click_area = ClickCommon.CLICK_AREA_BTN;
                clickCommon.click_scene = "appinfo";
                clickCommon.is_final_click = true;
            }

            @Override // com.sigmob.sdk.base.views.q.b
            public void b() {
                j.this.al = true;
                j.this.aq = true;
                j.this.O();
                if (j.this.ao != null) {
                    j.this.ao.b();
                }
            }
        });
        this.I.a((ac) this);
        this.F = this.L.getAdslot_id();
        o = this.L.getInteractionType();
        b(activity, this.J, intentExtras);
        this.L.getMacroCommon().addMarcoKey(SigMacroCommon._PLAYLASTFRAME_, "1");
        this.D = this.L.getMaterial().creative_type.intValue() != n.CreativeTypeVideo_transparent_html.a();
        if (savedInstanceState != null) {
            this.U = savedInstanceState.getInt(i, -1);
            this.V = savedInstanceState.getBoolean(j, false);
            this.Y = savedInstanceState.getBoolean(k, false);
        }
        if (this.e == null) {
            int iB = com.sigmob.sdk.base.k.b();
            if (iB != 0) {
                n().setTheme(iB);
            }
            m().setBackgroundColor(-16777216);
        } else {
            m().setBackgroundColor(0);
        }
        RelativeLayout relativeLayout = new RelativeLayout(this.f3184a);
        this.s = relativeLayout;
        relativeLayout.setBackgroundColor(-16777216);
        this.K = d(this.f3184a, 0);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, -2);
        layoutParams.addRule(13);
        this.s.addView(this.K, layoutParams);
        m().addView(this.s, new RelativeLayout.LayoutParams(-1, -1));
        if (this.u) {
            a(this.f3184a);
            E();
        }
        q();
        this.s.setClickable(true);
        this.s.setOnTouchListener(new View.OnTouchListener() { // from class: com.sigmob.sdk.videoAd.j.8

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            MotionEvent f3650a = null;

            /* JADX WARN: Code duplicated, block: B:32:0x009a  */
            @Override // android.view.View.OnTouchListener
            public boolean onTouch(View v, MotionEvent event) {
                if (!j.this.L.getFullClickOnVideo()) {
                    if (event.getAction() == 1) {
                        if (j.this.L.getMaterial().enable_collapse_tool_bar.booleanValue() && j.this.af != null && j.this.af.a()) {
                            if (j.this.af.b()) {
                                j.this.af.setVisibility(0);
                            } else {
                                j.this.af.setVisibility(4);
                            }
                        }
                        ad.a(j.this.L, event, "useless_video_click", false);
                    }
                    if (event.getAction() == 0) {
                        this.f3650a = MotionEvent.obtain(event);
                    }
                } else if (j.this.E == null || j.this.E.getVisibility() != 0) {
                    if (event.getAction() == 1) {
                        if (this.f3650a == null) {
                            this.f3650a = event;
                        }
                        j.this.a(this.f3650a, event);
                    } else if (event.getAction() == 0) {
                        this.f3650a = MotionEvent.obtain(event);
                    }
                }
                return true;
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void E() {
        RelativeLayout relativeLayout = this.Z;
        if (relativeLayout == null || relativeLayout.getVisibility() == 0) {
            return;
        }
        this.z = System.currentTimeMillis();
        this.Z.setVisibility(0);
        this.A = "loading";
        int i2 = this.v + 1;
        this.v = i2;
        if (i2 > 2) {
            a((int) this.K.getCurrentPositionWhenPlaying(), true);
        } else {
            this.C.postDelayed(new Runnable() { // from class: com.sigmob.sdk.videoAd.j$$ExternalSyntheticLambda6
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.ab();
                }
            }, 5000L);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void F() {
        RelativeLayout relativeLayout = this.Z;
        if (relativeLayout != null && relativeLayout.getVisibility() == 0) {
            this.x.add(String.format(Locale.getDefault(), "%d", Long.valueOf(System.currentTimeMillis() - this.z)));
            this.y.add(String.format(Locale.getDefault(), "%.2f", Float.valueOf(((int) this.K.getCurrentPositionWhenPlaying()) / 1000.0f)));
            this.A = PointCategory.PLAY;
            this.C.removeCallbacksAndMessages(null);
            this.Z.setVisibility(4);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void G() {
        com.sigmob.sdk.nativead.b bVar = this.ar;
        if (bVar == null) {
            return;
        }
        bVar.dismiss();
        this.ar.b();
        this.ar = null;
    }

    private void H() {
        switch ((int) this.L.getWidgetId(0)) {
            case 138731:
                L();
                break;
            case 138733:
                M();
                break;
            case 138757:
                I();
                break;
            case 138758:
                K();
                break;
        }
        com.sigmob.sdk.base.views.v vVar = this.ap;
        if (vVar == null) {
            return;
        }
        vVar.a();
    }

    private void I() {
        Context contextL = l();
        this.ap = new com.sigmob.sdk.base.views.ac(contextL);
        int iDipsToIntPixels = Dips.dipsToIntPixels(100.0f, contextL);
        int iDipsToIntPixels2 = Dips.dipsToIntPixels(145.0f, contextL);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(iDipsToIntPixels, iDipsToIntPixels);
        layoutParams.addRule(14);
        layoutParams.addRule(12);
        layoutParams.setMargins(0, 0, 0, iDipsToIntPixels2);
        am.a aVar = new am.a(contextL, new AnonymousClass10(), am.d.SHAKE);
        this.ao = aVar;
        aVar.a(SensorEntity.format(this.L));
        this.ao.a();
        m().addView(this.ap, layoutParams);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void J() {
        this.aq = true;
        ClickCommon clickCommon = this.L.getClickCommon();
        clickCommon.click_area = ClickCommon.CLICK_AREA_COMPONENT;
        clickCommon.click_scene = ClickCommon.CLICK_SCENE_AD;
        clickCommon.is_final_click = true;
        this.I.a(com.sigmob.sdk.base.a.MOTION, (String) null, true);
    }

    private void K() {
        Context contextL = l();
        this.ap = new aw(contextL);
        int iDipsToIntPixels = Dips.dipsToIntPixels(100.0f, contextL);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(iDipsToIntPixels, iDipsToIntPixels);
        layoutParams.addRule(14);
        layoutParams.addRule(12);
        layoutParams.setMargins(0, 0, 0, Dips.dipsToIntPixels(145.0f, contextL));
        am.a aVar = new am.a(contextL, new AnonymousClass11(), am.d.WRING);
        this.ao = aVar;
        aVar.a(SensorEntity.format(this.L));
        this.ao.a();
        m().addView(this.ap, layoutParams);
    }

    private void L() {
        Context contextL = l();
        this.ap = new ap(contextL);
        int iDipsToIntPixels = Dips.dipsToIntPixels(100.0f, contextL);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(iDipsToIntPixels, iDipsToIntPixels);
        layoutParams.addRule(14);
        layoutParams.addRule(12);
        layoutParams.setMargins(0, 0, 0, Dips.dipsToIntPixels(145.0f, contextL));
        am.a aVar = new am.a(contextL, new AnonymousClass12(), am.d.SWING);
        this.ao = aVar;
        aVar.a(SensorEntity.format(this.L));
        this.ao.a();
        m().addView(this.ap, layoutParams);
    }

    private void M() {
        Context contextL = l();
        this.ap = new com.sigmob.sdk.base.views.am(contextL);
        int iDipsToIntPixels = Dips.dipsToIntPixels(92.0f, contextL);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(iDipsToIntPixels, iDipsToIntPixels);
        layoutParams.addRule(14);
        layoutParams.addRule(12);
        layoutParams.setMargins(0, 0, 0, Dips.dipsToIntPixels(145.0f, contextL));
        am.a aVar = new am.a(contextL, new AnonymousClass13(), am.d.SLOPE);
        this.ao = aVar;
        aVar.a(SensorEntity.format(this.L));
        this.ao.a();
        m().addView(this.ap, layoutParams);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void N() {
        if (this.V) {
            return;
        }
        try {
            int currentPositionWhenPlaying = (int) this.K.getCurrentPositionWhenPlaying();
            if (this.U > 0 && currentPositionWhenPlaying == 0) {
                SigmobLog.d("video seek to " + this.U);
                this.K.a(this.U);
            }
            com.sigmob.sdk.base.views.d dVar = this.E;
            if ((dVar == null || dVar.getVisibility() != 0) && !this.al) {
                this.K.d();
            }
            if (this.U != -1) {
                this.I.a(l(), this.U);
            }
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void O() {
        if (this.V) {
            return;
        }
        try {
            this.K.j();
            SigmobLog.i("videoView.pause()");
            this.U = (int) this.K.getCurrentPositionWhenPlaying();
            r().a(com.sigmob.sdk.base.common.a.j, (int) this.K.getCurrentPositionWhenPlaying());
            this.I.b(l(), this.U);
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public float P() {
        if (y() <= 0) {
            return 0.0f;
        }
        return ((int) this.K.getCurrentPositionWhenPlaying()) / y();
    }

    private void Q() {
        try {
            this.T = this.I.e(y());
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void R() {
        if (this.as == null || this.L.getAd_type() == 4) {
            return;
        }
        int iB = B();
        if (iB > 0) {
            this.as.setText(iB + "s 后获取奖励");
        } else {
            this.as.setText("已获得奖励");
        }
    }

    private void S() {
        ad.a(PointCategory.PLAY_LOADING, (String) null, this.L, new ad.a() { // from class: com.sigmob.sdk.videoAd.j$$ExternalSyntheticLambda9
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                this.f$0.a(obj);
            }
        });
    }

    private void T() {
        int iO = this.I.o();
        int iY = y() - 2;
        if (iO == 99999999) {
            iO = 0;
        } else if (iO == -99999999) {
            a(iY);
            return;
        } else if (iO <= 0) {
            iO += iY;
        }
        a(iO);
    }

    private void U() {
        z zVar = this.ai;
        if (zVar == null) {
            return;
        }
        zVar.dismiss();
        this.ai.c();
        this.ai = null;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void V() {
        ImageView imageView;
        w wVar = this.as;
        if (wVar != null) {
            ViewUtil.removeFromParent(wVar);
        }
        w wVar2 = this.an;
        if (wVar2 != null) {
            ViewUtil.removeFromParent(wVar2);
        }
        com.sigmob.sdk.base.views.v vVar = this.ap;
        if (vVar != null) {
            ViewUtil.removeFromParent(vVar);
        }
        z();
        am.a aVar = this.ao;
        if (aVar != null) {
            aVar.c();
            this.ao = null;
        }
        if (!this.D && (imageView = this.r) != null) {
            ViewParent parent = imageView.getParent();
            if (parent instanceof ViewGroup) {
                ((ViewGroup) parent).removeView(this.r);
            }
            m().addView(this.r, 0);
        }
        com.sigmob.sdk.base.common.h.g().b(this);
        h(l(), 0);
        com.sigmob.sdk.base.views.b bVar = this.q;
        if (bVar != null) {
            bVar.setVisibility(8);
        }
        S();
        F();
        if (this.M == null) {
            SigmobLog.e("endcard can't show " + this.L.getEndCardIndexPath());
            HashMap map = new HashMap();
            map.put("error", "endcard can't show");
            a(IntentActions.ACTION_REWARDED_VIDEO_PLAYFAIL, map);
            this.d.a();
        }
        View view = this.M;
        if (view != null) {
            view.setVisibility(0);
            this.M.bringToFront();
        }
        RelativeLayout relativeLayout = this.s;
        if (relativeLayout != null) {
            relativeLayout.setVisibility(4);
            a(IntentActions.ACTION_REWARDED_VIDEO_CLOSE);
        }
        w wVar3 = this.R;
        if (wVar3 != null) {
            ViewUtil.removeFromParent(wVar3);
        }
        ar arVar = this.ab;
        if (arVar != null) {
            ViewUtil.removeFromParent(arVar);
        }
        if (this.ag) {
            ViewUtil.removeFromParent(this.P);
        }
        com.sigmob.sdk.base.views.m mVar = this.af;
        if (mVar != null) {
            ViewUtil.removeFromParent(mVar);
        }
        this.Y = true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void W() {
        com.sigmob.sdk.base.utils.d.a(f, this.L);
        this.C.post(new Runnable() { // from class: com.sigmob.sdk.videoAd.j$$ExternalSyntheticLambda13
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.X();
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void X() {
        a(IntentActions.ACTION_INTERSTITIAL_CLICK);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void Y() {
        a(IntentActions.ACTION_REWARDED_VIDEO_COMPLETE);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void Z() {
        U();
        this.aa = true;
        this.I.b(l(), y(), this.L);
        k().a();
    }

    private View a(Context context, f videoCompanionAdConfig, int initialVisibility) {
        Preconditions.NoThrow.checkNotNull(context);
        if (videoCompanionAdConfig == null) {
            View view = new View(context);
            view.setVisibility(4);
            return view;
        }
        RelativeLayout relativeLayout = new RelativeLayout(context);
        relativeLayout.setGravity(17);
        m().addView(relativeLayout, 0, new RelativeLayout.LayoutParams(-1, -1));
        o oVarA = a(context, videoCompanionAdConfig);
        oVarA.setVisibility(initialVisibility);
        relativeLayout.addView(oVarA, new LinearLayout.LayoutParams(-1, -1));
        return oVarA;
    }

    private o a(Context context, f videoCompanionAdConfig) {
        Preconditions.NoThrow.checkNotNull(context);
        Preconditions.NoThrow.checkNotNull(videoCompanionAdConfig);
        Preconditions.NoThrow.checkNotNull(videoCompanionAdConfig.a());
        o oVarA = o.a(context, this.L.getAd_source_logo(), false, this.L.getInvisibleAdLabel());
        oVarA.addJavascriptInterface(new a(), "sigVersion");
        oVarA.setWebViewClickListener(new o.a() { // from class: com.sigmob.sdk.videoAd.j$$ExternalSyntheticLambda2
            @Override // com.sigmob.sdk.base.views.o.a
            public final void onWebViewClick(MotionEvent motionEvent, MotionEvent motionEvent2) {
                this.f$0.b(motionEvent, motionEvent2);
            }
        });
        oVarA.setDownloadListener(new DownloadListener() { // from class: com.sigmob.sdk.videoAd.j$$ExternalSyntheticLambda3
            @Override // android.webkit.DownloadListener
            public final void onDownloadStart(String str, String str2, String str3, String str4, long j2) {
                this.f$0.a(str, str2, str3, str4, j2);
            }
        });
        oVarA.setAdUnit(this.L);
        oVarA.setWebViewClient(new AnonymousClass6());
        videoCompanionAdConfig.a().a(oVarA);
        oVarA.a((com.sigmob.sdk.base.common.b) null);
        return oVarA;
    }

    private String a(List<String> list) {
        if (list == null || list.isEmpty()) {
            return "";
        }
        StringBuilder sb = new StringBuilder("[");
        int i2 = 0;
        do {
            if (i2 != 0) {
                sb.append(',');
            }
            sb.append(list.get(i2));
            i2++;
        } while (i2 < list.size());
        sb.append(']');
        return sb.toString();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(final int seek) {
        try {
            ThreadPoolFactory.getFixIOExecutor().submit(new Runnable() { // from class: com.sigmob.sdk.videoAd.j$$ExternalSyntheticLambda7
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.c(seek);
                }
            });
        } catch (RuntimeException e) {
            SigmobLog.e(e.getMessage());
        }
    }

    private void a(int currentPosition, boolean isShowForce) {
        w wVar = this.R;
        if (wVar == null || this.au) {
            return;
        }
        this.au = true;
        wVar.setText("跳过");
        this.R.setEnabled(true);
        ValueAnimator duration = ValueAnimator.ofInt(Dips.dipsToIntPixels(22.0f, l()), Dips.dipsToIntPixels(45.0f, l())).setDuration(300L);
        duration.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.sigmob.sdk.videoAd.j$$ExternalSyntheticLambda12
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                this.f$0.a(valueAnimator);
            }
        });
        duration.start();
        this.R.setVisibility(0);
        r().a(isShowForce, currentPosition);
        r().a("show_skip", currentPosition);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(ValueAnimator valueAnimator) {
        int iIntValue = ((Integer) valueAnimator.getAnimatedValue()).intValue();
        RelativeLayout.LayoutParams layoutParams = (RelativeLayout.LayoutParams) this.R.getLayoutParams();
        layoutParams.width = iIntValue;
        this.R.setLayoutParams(layoutParams);
        this.R.invalidate();
    }

    private void a(Context context, int visibility) {
        if (this.an == null) {
            w wVar = new w(context);
            this.an = wVar;
            wVar.setText("反馈");
            this.an.setId(ClientMetadata.generateViewId());
            this.an.setOnClickListener(this.ay);
            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(Dips.dipsToIntPixels(45.0f, context), Dips.dipsToIntPixels(22.0f, context));
            layoutParams.addRule(9);
            layoutParams.addRule(10);
            int i2 = this.p;
            layoutParams.setMargins(i2, i2 * 2, 0, 0);
            m().addView(this.an, layoutParams);
        }
        w wVar2 = this.an;
        if (wVar2 != null) {
            wVar2.setVisibility(visibility);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(Bitmap bitmap) {
        this.r.setScaleType(ImageView.ScaleType.FIT_XY);
        this.r.setImageBitmap(bitmap);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(MotionEvent downEvent, MotionEvent upEvent) {
        boolean z;
        this.L.getClickCommon().click_area = ClickCommon.CLICK_AREA_MATERIAL;
        this.L.getClickCommon().click_scene = ClickCommon.CLICK_SCENE_AD;
        ClickAreaSetting clickAreaSetting = this.L.getClickAreaSetting();
        float fFloatValue = clickAreaSetting.left.floatValue() * ClientMetadata.getInstance().getDisplayMetrics().widthPixels;
        float fFloatValue2 = (1.0f - clickAreaSetting.right.floatValue()) * ClientMetadata.getInstance().getDisplayMetrics().widthPixels;
        float fFloatValue3 = clickAreaSetting.top.floatValue() * ClientMetadata.getInstance().getDisplayMetrics().heightPixels;
        float fFloatValue4 = (1.0f - clickAreaSetting.bottom.floatValue()) * ClientMetadata.getInstance().getDisplayMetrics().heightPixels;
        if (fFloatValue >= upEvent.getRawX() || upEvent.getRawX() >= fFloatValue2 || fFloatValue3 >= upEvent.getRawY() || upEvent.getRawY() >= fFloatValue4) {
            z = false;
        } else {
            SigMacroCommon macroCommon = this.L.getMacroCommon();
            macroCommon.addMarcoKey(SigMacroCommon._PROGRESS_, String.valueOf(((int) P()) * 100));
            z = true;
            macroCommon.updateClickMarco(downEvent, upEvent, true);
            this.h = macroCommon.getCoordinate();
            if (this.S == null) {
                z();
            }
            this.I.a(com.sigmob.sdk.base.a.VIDEO_CLICK, this.h, true);
        }
        ad.a(this.L, upEvent, "useless_video_click", z);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(View view) {
        r().a(com.sigmob.sdk.base.common.a.r, (int) this.K.getCurrentPositionWhenPlaying());
        if (C()) {
            b(false);
        }
        if (this.ad || this.L.getConfirmDialog() == 2 || this.L.getAd_type() == 4) {
            r().a("skip", (int) this.K.getCurrentPositionWhenPlaying());
            this.I.b(this.f3184a, (int) this.K.getCurrentPositionWhenPlaying(), y(), this.L);
            a(false, false);
            return;
        }
        this.K.j();
        SigmobLog.i("videoView.pause()");
        this.E.setDuration(B());
        this.E.setVisibility(0);
        com.sigmob.sdk.base.views.m mVar = this.af;
        if (mVar == null || mVar.getFourElementsLayout() == null) {
            return;
        }
        this.af.getFourElementsLayout().setClickable(false);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(Object obj) {
        if (obj instanceof PointEntitySigmob) {
            PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
            Map<String, String> options = pointEntitySigmob.getOptions();
            options.put("duration_seq", a(this.x));
            options.put("video_time_seq", a(this.y));
            options.put("skip_state", this.A);
            options.put("video_duration", String.format(Locale.getDefault(), "%.2f", Float.valueOf(y() / 1000.0f)));
            options.put("endcard_loading_state", this.w);
            pointEntitySigmob.setOptions(options);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(String str, String str2, String str3, String str4, long j2) {
        if (this.B) {
            if (s.a((CharSequence) this.L.getLanding_page()) || this.L.getInteractionType() == 2) {
                this.L.setCustomLandPageUrl(str);
            }
            this.L.getClickCommon().click_area = ClickCommon.CLICK_AREA_COMPANION;
            this.L.getClickCommon().click_scene = "endcard";
            this.I.a(com.sigmob.sdk.base.a.ENDCARD, this.h, true);
            SigmobLog.d("onDownloadStart() called with: url = [" + str + "], userAgent = [" + str2 + "], contentDisposition = [" + str3 + "], mimetype = [" + str4 + "], contentLength = [" + j2 + "]");
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void aa() {
        if (new File(this.L.getVideoPath()).exists()) {
            this.O.setDataSource(this.L.getVideoPath());
        } else {
            this.O.setDataSource(this.L.getVideo_url(), new HashMap());
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void ab() {
        this.C.removeCallbacksAndMessages(null);
        a((int) this.K.getCurrentPositionWhenPlaying(), true);
    }

    private ImageView b(Context context) {
        ImageView imageView = new ImageView(context);
        imageView.setLayoutParams(new RelativeLayout.LayoutParams(-1, -1));
        return imageView;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(final int type) {
        if (this.ak == null) {
            q qVar = new q(n(), this.L);
            this.ak = qVar;
            qVar.a(new q.b() { // from class: com.sigmob.sdk.videoAd.j.5
                @Override // com.sigmob.sdk.base.views.q.b
                public void a() {
                    if (j.this.ak != null) {
                        j.this.ak.dismiss();
                        j.this.ak.c();
                        j.this.ak = null;
                        j.this.al = false;
                    }
                    if (j.this.K != null && type == 1) {
                        j.this.K.d();
                    }
                    if (j.this.ao != null) {
                        j.this.ao.a();
                    }
                    j.this.r().a(com.sigmob.sdk.base.common.a.g, (int) j.this.K.getCurrentPositionWhenPlaying());
                }

                @Override // com.sigmob.sdk.base.views.q.b
                public void a(Error error) {
                }

                @Override // com.sigmob.sdk.base.views.q.b
                public void a(String url, String clickCoordinate) {
                    if (j.this.S == null) {
                        j.this.z();
                    }
                    ClickCommon clickCommon = j.this.L.getClickCommon();
                    clickCommon.click_area = ClickCommon.CLICK_AREA_BTN;
                    clickCommon.click_scene = "appinfo";
                    j.this.I.a(com.sigmob.sdk.base.a.ENDCARD, url, clickCoordinate, true);
                }

                @Override // com.sigmob.sdk.base.views.q.b
                public void b() {
                    if (j.this.K != null && type == 1) {
                        j.this.K.j();
                    }
                    if (j.this.ao != null) {
                        j.this.ao.b();
                    }
                    j.this.r().a(com.sigmob.sdk.base.common.a.f, (int) j.this.K.getCurrentPositionWhenPlaying());
                }
            });
        }
        q qVar2 = this.ak;
        if (qVar2 == null || !qVar2.a() || this.al) {
            return;
        }
        this.ak.show();
        this.al = true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(Context context, int visibility) {
        if (this.L.getRewardStyle() == 1) {
            this.as = new w(context);
            int iB = B();
            if (iB > 0) {
                this.as.setText(iB + "s 后获取奖励");
            } else {
                this.as.setText("已获得奖励");
                b(false);
            }
            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(Dips.dipsToIntPixels(97.0f, context), Dips.dipsToIntPixels(22.0f, context));
            layoutParams.addRule(1, this.an.getId());
            int i2 = this.p;
            layoutParams.setMargins(i2, i2 * 2, 0, 0);
            m().addView(this.as, layoutParams);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(MotionEvent motionEvent, MotionEvent motionEvent2) {
        if (this.Q.getVisibility() != 0 || this.aa) {
            SigmobLog.w("ignore invalid click");
            return;
        }
        this.L.getClickCommon().sld = "0";
        ad.a(this.L, motionEvent2, PointCategory.ENDCARDCLICK, true);
        SigMacroCommon macroCommon = this.L.getMacroCommon();
        macroCommon.updateClickMarco(motionEvent, motionEvent2, true);
        this.h = macroCommon.getCoordinate();
        this.B = true;
        if (this.L.getMaterial().click_type.intValue() != com.sigmob.sdk.base.common.m.FullScreen.a() || s.a((CharSequence) this.L.getLanding_page()) || this.L.getMaterial().creative_type.intValue() == n.CreativeTypeVideo_EndCardURL.a()) {
            this.ah = true;
            return;
        }
        this.L.getClickCommon().click_area = ClickCommon.CLICK_AREA_MATERIAL;
        this.L.getClickCommon().click_scene = "endcard";
        this.I.a(com.sigmob.sdk.base.a.ENDCARD, this.h, true);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(View view) {
        b(1);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void c(int i2) {
        final Bitmap frameAtTime = this.O.getFrameAtTime(((long) i2) * 1000, 2);
        if (frameAtTime == null) {
            return;
        }
        this.C.post(new Runnable() { // from class: com.sigmob.sdk.videoAd.j$$ExternalSyntheticLambda11
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.a(frameAtTime);
            }
        });
    }

    private void c(Context context, int visibility) {
        if (this.am == null) {
            w wVar = new w(context);
            this.am = wVar;
            wVar.setText("反馈");
            this.am.setOnClickListener(this.ay);
            this.am.setId(ClientMetadata.generateViewId());
            int iDipsToIntPixels = Dips.dipsToIntPixels(3.0f, this.f3184a);
            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(Dips.dipsToIntPixels(45.0f, context), Dips.dipsToIntPixels(30.0f, context));
            layoutParams.addRule(0, this.Q.getId());
            layoutParams.addRule(6, this.Q.getId());
            layoutParams.setMargins(0, -iDipsToIntPixels, 0, 0);
            m().addView(this.am, layoutParams);
        }
        w wVar2 = this.am;
        if (wVar2 != null) {
            wVar2.setVisibility(visibility);
        }
    }

    private void c(String url) {
        Uri uri;
        if (s.a((CharSequence) url) || (uri = Uri.parse(url)) == null) {
            return;
        }
        String host = uri.getHost();
        if (!s.a((CharSequence) host) && host.equalsIgnoreCase("127.0.0.1")) {
            Pattern patternCompile = Pattern.compile("/(.*)");
            String path = uri.getPath();
            if (s.a((CharSequence) path)) {
                return;
            }
            Matcher matcher = patternCompile.matcher(path);
            if (matcher.find()) {
                this.ax = matcher.group(1);
                com.sigmob.sdk.base.common.h.d().registerCacheListener(this, this.ax);
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void c(boolean isComplete) {
        if (this.at || this.L.getAd_type() == 4) {
            return;
        }
        this.at = true;
        int iY = isComplete ? y() : (int) this.K.getCurrentPositionWhenPlaying();
        r().a(com.sigmob.sdk.base.common.a.b, iY);
        this.I.c(l().getApplicationContext(), iY, y(), a());
    }

    private com.sigmob.sdk.videoplayer.a d(Context context, int initialVisibility) {
        if (this.L.getProxyVideoUrl() == null) {
            throw new IllegalStateException("BaseVideoConfig does not have a video disk path");
        }
        final com.sigmob.sdk.videoplayer.a aVar = new com.sigmob.sdk.videoplayer.a(context);
        aVar.setVideoPlayerStatusListener(new com.sigmob.sdk.videoplayer.k() { // from class: com.sigmob.sdk.videoAd.j.14
            @Override // com.sigmob.sdk.videoplayer.k
            public void a(long position, long duration) {
                int iY = j.this.y();
                j.this.R();
                if (j.this.C()) {
                    j.this.b(false);
                }
                if (j.this.u()) {
                    j.this.c(false);
                }
                int iB = j.this.B();
                if (j.this.E != null) {
                    j.this.E.setDuration(iB);
                }
                if (j.this.ag) {
                    j.this.P.a((int) j.this.K.getCurrentPositionWhenPlaying());
                }
                long j2 = iY;
                if (1000 + position < j2) {
                    if (j.this.t()) {
                        j.this.A();
                    } else if (!j.this.au) {
                        j.this.R.setText(String.valueOf((int) ((j2 - j.this.K.getCurrentPositionWhenPlaying()) / 1000.0f)));
                    }
                }
                if (j.this.v()) {
                    j.this.w();
                }
                for (d dVar : j.this.I.a(position, j2)) {
                    j.this.b(dVar.getEvent());
                    dVar.setTracked();
                }
                if (position > j2) {
                    j.this.a(true, false);
                }
            }

            @Override // com.sigmob.sdk.videoplayer.k
            public void a(com.sigmob.sdk.videoplayer.d state) {
                SigmobLog.i("video player state change " + state);
                int i2 = AnonymousClass7.f3649a[state.ordinal()];
                if (i2 != 1) {
                    if (i2 == 3) {
                        j.this.A = "none";
                        j.this.a(true, false);
                        return;
                    }
                    if (i2 == 8) {
                        ad.a("video", aVar.getErrorCode(), aVar.getErrorMessage(), j.this.L, (ad.a) null);
                        j.this.a(false, true);
                        return;
                    } else if (i2 == 5) {
                        j.this.E();
                        aVar.j();
                        return;
                    } else {
                        if (i2 != 6) {
                            return;
                        }
                        j.this.F();
                        aVar.d();
                        return;
                    }
                }
                j.this.X = (int) aVar.getDuration();
                if (j.this.X == 0) {
                    j jVar = j.this;
                    jVar.X = jVar.L.getDuration();
                }
                if (!j.this.au) {
                    j.this.R.setText(String.valueOf((int) (j.this.y() / 1000.0f)));
                    j.this.R.setVisibility(0);
                }
                j jVar2 = j.this;
                jVar2.b(jVar2.l(), 0);
                aVar.getVideoWidth();
                aVar.getVideoHeight();
                if (j.this.S != null) {
                    j.this.S.a(j.this.y());
                }
                if (j.this.ac) {
                    j.this.ab.a(ResourceUtil.getDrawableId(j.this.l(), "sig_image_video_mute"));
                    j.this.K.setMute(true);
                }
                j.this.r().a(j.this.X, j.this.I.l());
                if (!j.this.V && (j.this.U == 0 || j.this.U == -1)) {
                    SigMacroCommon macroCommon = j.this.L.getMacroCommon();
                    macroCommon.addMarcoKey(SigMacroCommon._COMPLETED_, "0");
                    macroCommon.addMarcoKey(SigMacroCommon._VIDEOTIME_, String.valueOf(j.this.y() / 1000));
                }
                if (j.this.ag) {
                    j.this.P.a(j.this.y(), 0);
                }
            }
        });
        try {
            if (!this.D) {
                ThreadPoolFactory.getFixIOExecutor().submit(new Runnable() { // from class: com.sigmob.sdk.videoAd.j$$ExternalSyntheticLambda1
                    @Override // java.lang.Runnable
                    public final void run() {
                        this.f$0.aa();
                    }
                });
                this.r = b(context);
            }
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
        }
        String proxyVideoUrl = this.L.getProxyVideoUrl();
        aVar.setUp(proxyVideoUrl);
        c(proxyVideoUrl);
        aVar.setVisibility(initialVisibility);
        return aVar;
    }

    private void e(final Context context, int initialVisibility) {
        as asVar = new as(context);
        this.P = asVar;
        asVar.setAnchorId(this.K.getId());
        this.P.setVisibility(initialVisibility);
        m().addView(this.P);
    }

    private void f(final Context context, int initialVisibility) {
        if (this.E != null) {
            return;
        }
        com.sigmob.sdk.base.views.d dVar = new com.sigmob.sdk.base.views.d(context, this.I.q());
        this.E = dVar;
        dVar.setVisibility(initialVisibility);
        m().addView(this.E);
        this.E.setDialogListener(new com.sigmob.sdk.base.views.d.a() { // from class: com.sigmob.sdk.videoAd.j.15
            @Override // com.sigmob.sdk.base.views.d.a
            public void a() {
                if (!j.this.V) {
                    j.this.r().a("skip", (int) j.this.K.getCurrentPositionWhenPlaying());
                    j.this.I.b(j.this.f3184a, (int) j.this.K.getCurrentPositionWhenPlaying(), j.this.y(), j.this.L);
                }
                j.this.E.setVisibility(8);
                if (j.this.af != null && j.this.af.getFourElementsLayout() != null) {
                    j.this.af.getFourElementsLayout().setClickable(true);
                }
                if (j.this.I.m()) {
                    j.this.k().a();
                    return;
                }
                if (!j.this.D) {
                    j jVar = j.this;
                    jVar.a((int) jVar.K.getCurrentPositionWhenPlaying());
                }
                j.this.K.i();
                j.this.V();
                j.this.V = true;
                if (j.this.r() != null) {
                    j.this.N.a("show", 0);
                }
            }

            @Override // com.sigmob.sdk.base.views.d.a
            public void b() {
                j.this.K.d();
                j.this.E.setVisibility(8);
                if (j.this.af == null || j.this.af.getFourElementsLayout() == null) {
                    return;
                }
                j.this.af.getFourElementsLayout().setClickable(true);
            }
        });
    }

    private void g(final Context context, int initialVisibility) {
        int iArgb;
        int iIntValue;
        boolean z;
        CompanionEndcard companionEndcard = this.L.getMaterial().companion;
        if (companionEndcard == null || s.a((CharSequence) companionEndcard.icon_url) || s.a((CharSequence) companionEndcard.title) || (s.a((CharSequence) companionEndcard.desc) && companionEndcard.score.floatValue() < 1.0f)) {
            SigmobLog.e("ompanionEnd lose informations of UI Display");
            return;
        }
        int iArgb2 = r.f3355a;
        int iRgb = -1;
        int iFloatValue = 229;
        try {
            if (companionEndcard.button_color != null && companionEndcard.button_color.alpha.floatValue() > 0.01d) {
                try {
                    iArgb2 = Color.argb((int) (companionEndcard.button_color.alpha.floatValue() * 255.0f), companionEndcard.button_color.red.intValue(), companionEndcard.button_color.green.intValue(), companionEndcard.button_color.blue.intValue());
                } catch (Throwable unused) {
                }
            }
            if (companionEndcard.button_text_color == null || companionEndcard.button_text_color.alpha.floatValue() <= 0.01d) {
                iArgb = -1;
            } else {
                try {
                    iArgb = Color.argb((int) (companionEndcard.button_text_color.alpha.floatValue() * 255.0f), companionEndcard.button_text_color.red.intValue(), companionEndcard.button_text_color.green.intValue(), companionEndcard.button_text_color.blue.intValue());
                } catch (Throwable unused2) {
                    iArgb = -1;
                }
            }
            try {
                if (companionEndcard.bar_color != null && companionEndcard.bar_color.alpha.floatValue() > 0.01d) {
                    iFloatValue = (int) (companionEndcard.bar_color.alpha.floatValue() * 255.0f);
                    iRgb = Color.rgb(companionEndcard.button_text_color.red.intValue(), companionEndcard.button_text_color.green.intValue(), companionEndcard.button_text_color.blue.intValue());
                }
            } catch (Throwable unused3) {
            }
        } catch (Throwable unused4) {
            iArgb = -1;
        }
        int i2 = iArgb2;
        int i3 = iRgb;
        int i4 = iFloatValue;
        int i5 = iArgb;
        try {
            iIntValue = companionEndcard.click_type != null ? companionEndcard.click_type.intValue() : 0;
        } catch (Throwable unused5) {
            iIntValue = 0;
        }
        String str = companionEndcard.button_text;
        if (s.a((CharSequence) str) || str.length() > 4) {
            str = a().getInteractionType() == 2 ? "下载" : "详情";
        }
        com.sigmob.sdk.base.views.m mVar = new com.sigmob.sdk.base.views.m(context, this.L, companionEndcard.title, str, companionEndcard.score.floatValue(), companionEndcard.desc, companionEndcard.animate_type.intValue(), this.L.getMaterial().template_type.intValue(), companionEndcard.icon_url, i2, i5, iIntValue, i3, i4, 70.0f);
        this.af = mVar;
        mVar.setId(ClientMetadata.generateViewId());
        LinearLayout fourElementsLayout = this.af.getFourElementsLayout();
        if (fourElementsLayout != null) {
            fourElementsLayout.setClickable(true);
            fourElementsLayout.setOnClickListener(new View.OnClickListener() { // from class: com.sigmob.sdk.videoAd.j$$ExternalSyntheticLambda8
                @Override // android.view.View.OnClickListener
                public final void onClick(View view) {
                    this.f$0.b(view);
                }
            });
        }
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams((Math.max(context.getResources().getDisplayMetrics().widthPixels, context.getResources().getDisplayMetrics().heightPixels) * 3) / 5, Dips.asIntPixels(70.0f, context));
        int iAsIntPixels = Dips.asIntPixels(8.0f, context);
        if (this.q == null) {
            z = false;
            layoutParams.setMargins(iAsIntPixels, 0, iAsIntPixels, this.t + iAsIntPixels);
            layoutParams.addRule(11);
            layoutParams.addRule(12);
        } else {
            z = false;
            layoutParams.setMargins(iAsIntPixels, 0, iAsIntPixels, 0);
            layoutParams.addRule(11);
            layoutParams.addRule(2, this.q.getId());
        }
        m().addView(this.af, layoutParams);
        this.H = z;
        this.af.setClickable(true);
        this.af.setOnTouchListener(new View.OnTouchListener() { // from class: com.sigmob.sdk.videoAd.j.2

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            MotionEvent f3645a;

            @Override // android.view.View.OnTouchListener
            public boolean onTouch(View v, MotionEvent event) {
                SigmobLog.d("mCompanionAdsWidget click" + event.toString());
                if (event.getAction() == 1) {
                    ad.a(j.this.L, event, com.sigmob.sdk.base.common.a.s, true);
                    if (this.f3645a == null) {
                        this.f3645a = event;
                    }
                    SigMacroCommon macroCommon = j.this.L.getMacroCommon();
                    macroCommon.addMarcoKey(SigMacroCommon._PROGRESS_, String.valueOf(((int) j.this.P()) * 100));
                    macroCommon.updateClickMarco(this.f3645a, event, true);
                    j.this.h = SigMacroCommon.getCoordinate(this.f3645a, event, true);
                    if (j.this.S == null) {
                        j.this.z();
                    }
                    ClickCommon clickCommon = j.this.L.getClickCommon();
                    clickCommon.sld = "0";
                    clickCommon.click_area = ClickCommon.CLICK_AREA_COMPANION;
                    clickCommon.click_scene = ClickCommon.CLICK_SCENE_AD;
                    j.this.I.a(com.sigmob.sdk.base.a.COMPANION, j.this.h, true);
                } else if (event.getAction() == 0) {
                    this.f3645a = MotionEvent.obtain(event);
                }
                return true;
            }
        });
    }

    private void h(Context context, int initialVisibility) {
        if (this.Q == null) {
            ar arVar = new ar(context);
            this.Q = arVar;
            arVar.setId(ClientMetadata.generateViewId());
            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(Dips.dipsToIntPixels(22.0f, context), Dips.dipsToIntPixels(22.0f, context));
            layoutParams.addRule(10);
            layoutParams.addRule(11);
            int i2 = this.p;
            layoutParams.setMargins(i2, i2 * 2, i2, i2);
            m().addView(this.Q, layoutParams);
            BaseAdUnit baseAdUnit = this.L;
            if (baseAdUnit != null && !s.a((CharSequence) baseAdUnit.getCloseCardHtmlData()) && !this.az) {
                z zVar = new z(n(), this.L, this.I);
                this.ai = zVar;
                zVar.a(new z.a() { // from class: com.sigmob.sdk.videoAd.j$$ExternalSyntheticLambda10
                    @Override // com.sigmob.sdk.base.views.z.a
                    public final void onCloseClick() {
                        this.f$0.Z();
                    }
                });
            }
            this.Q.setOnTouchListener(new View.OnTouchListener() { // from class: com.sigmob.sdk.videoAd.j.3
                @Override // android.view.View.OnTouchListener
                public boolean onTouch(View view, MotionEvent motionEvent) {
                    if (motionEvent.getAction() == 1) {
                        if (j.this.az || j.this.ai == null || j.this.ai.a() || j.this.aj) {
                            j.this.aa = true;
                            j.this.I.b(j.this.l(), j.this.y(), j.this.L);
                            j.this.k().a();
                        } else {
                            j.this.ai.show();
                            j.this.aj = true;
                        }
                    }
                    return true;
                }
            });
            this.Q.a(this.L);
            String strF = this.I.f();
            if (strF != null) {
                this.Q.a(strF);
            }
        }
        ar arVar2 = this.Q;
        if (arVar2 != null) {
            arVar2.setVisibility(initialVisibility);
        }
        c(l(), initialVisibility);
    }

    private void i(final Context context, int initialVisibility) {
        w wVar = new w(context);
        this.R = wVar;
        wVar.setId(ClientMetadata.generateViewId());
        this.R.setVisibility(initialVisibility);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(Dips.dipsToIntPixels(22.0f, context), Dips.dipsToIntPixels(22.0f, context));
        layoutParams.addRule(10);
        ar arVar = this.ab;
        if (arVar != null) {
            layoutParams.addRule(0, arVar.getId());
            layoutParams.setMargins(0, this.p * 2, 0, 0);
        }
        m().addView(this.R, layoutParams);
        this.R.setEnabled(false);
        this.R.setOnClickListener(new View.OnClickListener() { // from class: com.sigmob.sdk.videoAd.j$$ExternalSyntheticLambda4
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                this.f$0.a(view);
            }
        });
        if ((this.L.getSkipPercent() != 0 || this.L.getSkipSeconds() >= 0) && this.L.getSkipSeconds() != 0) {
            return;
        }
        a(0, false);
    }

    private void j(final Context context, int initialVisibility) {
        ar arVar = new ar(context);
        this.ab = arVar;
        arVar.setId(ClientMetadata.generateViewId());
        this.ab.setVisibility(initialVisibility);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(Dips.dipsToIntPixels(22.0f, context), Dips.dipsToIntPixels(22.0f, context));
        layoutParams.addRule(4, this.an.getId());
        layoutParams.addRule(11);
        int i2 = this.p;
        layoutParams.setMargins(i2, i2 * 2, i2, 0);
        m().addView(this.ab, layoutParams);
        this.ab.setOnTouchListener(new View.OnTouchListener() { // from class: com.sigmob.sdk.videoAd.j.4
            @Override // android.view.View.OnTouchListener
            public boolean onTouch(View view, MotionEvent motionEvent) {
                if (motionEvent.getAction() == 1) {
                    if (j.this.ac) {
                        j.this.r().a(com.sigmob.sdk.base.common.a.A, (int) j.this.K.getCurrentPositionWhenPlaying());
                        j.this.ab.a(ResourceUtil.getDrawableId(j.this.l(), "sig_image_video_unmute"));
                        j.this.K.setMute(false);
                    } else {
                        j.this.r().a(com.sigmob.sdk.base.common.a.z, (int) j.this.K.getCurrentPositionWhenPlaying());
                        j.this.ab.a(ResourceUtil.getDrawableId(j.this.l(), "sig_image_video_mute"));
                        j.this.K.setMute(true);
                    }
                    j jVar = j.this;
                    jVar.ac = !jVar.ac;
                }
                return true;
            }
        });
        if (this.L.getIsMute() == 0) {
            this.ab.a(ResourceUtil.getDrawableId(l(), "sig_image_video_unmute"));
        } else {
            this.ab.a(ResourceUtil.getDrawableId(l(), "sig_image_video_mute"));
            this.K.setMute(true);
            this.ac = true;
        }
    }

    public static int p() {
        return 0;
    }

    void A() {
        if (this.L.getMaterial().disable_auto_deeplink.booleanValue()) {
            z();
        }
        a((int) this.K.getCurrentPositionWhenPlaying(), false);
        int iB = B();
        com.sigmob.sdk.base.views.d dVar = this.E;
        if (dVar != null) {
            dVar.setDuration(iB);
        }
    }

    int B() {
        try {
            int rewardSeconds = this.L.getRewardSeconds();
            if (rewardSeconds > -1) {
                if (y() > 0 && rewardSeconds * 1000 > y()) {
                    rewardSeconds = (int) (y() / 1000.0f);
                }
                return (int) (rewardSeconds - (this.K.getCurrentPositionWhenPlaying() / 1000.0f));
            }
            if (y() <= 0) {
                return -1;
            }
            return (int) ((((double) (y() / 1000.0f)) * (((double) this.L.getRewardPercent()) * 0.01d)) - ((double) (this.K.getCurrentPositionWhenPlaying() / 1000.0f)));
        } catch (Throwable unused) {
            return -1;
        }
    }

    boolean C() {
        return B() <= 0;
    }

    @Override // com.sigmob.sdk.base.common.h.a
    public BaseAdUnit a() {
        return this.L;
    }

    @Override // com.sigmob.sdk.base.common.j
    public void a(int requestCode, int resultCode, Intent data) {
        if (resultCode == -1) {
            k().a();
        }
    }

    public void a(Context context) {
        this.Z = new RelativeLayout(context);
        ImageView imageView = new ImageView(context);
        imageView.setImageBitmap(com.sigmob.sdk.base.views.s.LOADING.a());
        imageView.setId(ClientMetadata.generateViewId());
        RotateAnimation rotateAnimation = new RotateAnimation(0.0f, BaseConstants.Time.HOUR, 1, 0.5f, 1, 0.5f);
        rotateAnimation.setDuration(GmsVersion.VERSION_SAGA);
        rotateAnimation.setInterpolator(new LinearInterpolator());
        rotateAnimation.setRepeatCount(-1);
        rotateAnimation.setRepeatMode(1);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-2, -2);
        layoutParams.addRule(13);
        imageView.setAnimation(rotateAnimation);
        this.Z.addView(imageView, layoutParams);
        this.Z.setVisibility(4);
        RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(-2, -2);
        layoutParams2.addRule(13);
        m().addView(this.Z, layoutParams2);
    }

    @Override // com.sigmob.sdk.base.common.j
    public void a(final Configuration newConfig) {
        if (this.I != null && this.S == null) {
            f fVarE = com.sigmob.sdk.videoAd.a.e(this.L);
            this.S = fVarE;
            fVarE.a(this.I);
        }
        v vVarR = r();
        if (vVarR == null) {
            return;
        }
        vVarR.a(com.sigmob.sdk.base.common.a.B, (int) this.K.getCurrentPositionWhenPlaying());
    }

    @Override // com.sigmob.sdk.base.common.j
    public void a(Bundle outState) {
        try {
            outState.putBoolean(j, this.V);
            outState.putInt(i, this.U);
            outState.putBoolean(k, this.Y);
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
        }
    }

    @Override // com.sigmob.sdk.base.common.h.a
    public void a(BaseAdUnit adUnit) {
        if (adUnit.getUuid().equals(this.L.getUuid()) && adUnit.isEndCardIndexExist()) {
            this.C.post(new Runnable() { // from class: com.sigmob.sdk.videoAd.j$$ExternalSyntheticLambda5
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.z();
                }
            });
        }
    }

    @Override // com.sigmob.sdk.videocache.d
    public void a(File cacheFile, String url, int percentsAvailable) {
    }

    @Override // com.sigmob.sdk.videocache.d
    public void a(String url, Throwable th) {
        SigmobLog.e("url", th);
        ad.a("video", 0, th.getMessage(), this.L, (ad.a) null);
        a(false, true);
    }

    public void a(boolean isComplete, boolean isError) {
        if (this.aw) {
            return;
        }
        this.aw = true;
        F();
        boolean videoErrorReward = this.L.getVideoErrorReward();
        c(isComplete);
        if (isComplete || (isError && videoErrorReward)) {
            b(isComplete);
            if (isComplete) {
                x();
            }
        } else if (this.I.m()) {
            k().a();
            return;
        }
        if (!this.D) {
            if (isComplete) {
                T();
            } else {
                a((int) this.K.getCurrentPositionWhenPlaying());
            }
        }
        this.K.i();
        V();
        this.V = true;
        v vVarR = r();
        if (vVarR == null) {
            return;
        }
        vVarR.a("show", 0);
    }

    @Override // com.sigmob.sdk.base.common.h.a
    public void b(BaseAdUnit adUnit) {
    }

    void b(String adEvent) {
        if ("start".equals(adEvent)) {
            a(IntentActions.ACTION_INTERSTITIAL_SHOW);
            a(IntentActions.ACTION_REWARDED_VIDEO_PLAY);
        }
        v vVarR = r();
        if (vVarR == null) {
            return;
        }
        vVarR.a(adEvent, (int) this.K.getCurrentPositionWhenPlaying());
    }

    void b(boolean isComplete) {
        if (this.L.getAd_type() == 4 || this.ad) {
            return;
        }
        this.ad = true;
        int iY = isComplete ? y() : (int) this.K.getCurrentPositionWhenPlaying();
        this.C.postDelayed(new Runnable() { // from class: com.sigmob.sdk.videoAd.j$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.Y();
            }
        }, 100L);
        r().a("reward", iY);
        this.I.c(l().getApplicationContext(), iY, y(), a());
    }

    @Override // com.sigmob.sdk.videoAd.b, com.sigmob.sdk.base.common.j
    public void e() {
        super.e();
        n().getWindow().addFlags(1024);
        MaterialMeta material = this.L.getMaterial();
        this.t = ClientMetadata.getInstance().getInsetBottom();
        if (this.Y) {
            V();
        } else {
            if (this.I == null) {
                throw new IllegalStateException("BaseVideoConfig does not have a video disk path");
            }
            if (this.ag) {
                e(l(), 4);
            }
            if (material.has_companion_endcard != null && material.has_companion_endcard.booleanValue() && material.companion != null) {
                g(l(), 4);
                this.G = material.companion.show_delay_secs.intValue();
            }
            a(l(), 0);
            j(l(), 0);
            i(l(), 4);
            ArrayList arrayList = new ArrayList();
            arrayList.add(new d("start", 0.0f));
            arrayList.add(new d(com.sigmob.sdk.base.common.a.k, 0.25f));
            arrayList.add(new d(com.sigmob.sdk.base.common.a.m, 0.5f));
            arrayList.add(new d(com.sigmob.sdk.base.common.a.n, 0.75f));
            this.I.a((List<d>) arrayList);
            a(IntentActions.ACTION_INTERSTITIAL_VOPEN);
        }
        f(l(), 4);
        H();
    }

    @Override // com.sigmob.sdk.base.common.j
    public void f() {
        if (this.aa) {
            a(IntentActions.ACTION_INTERSTITIAL_DISMISS);
            return;
        }
        am.a aVar = this.ao;
        if (aVar != null) {
            aVar.b();
            com.sigmob.sdk.base.views.v vVar = this.ap;
            if (vVar != null) {
                vVar.b();
            }
        }
        if (this.Y) {
            return;
        }
        O();
    }

    @Override // com.sigmob.sdk.base.common.j
    public void g() {
        am.a aVar;
        if (!this.Y && this.ar == null) {
            N();
        }
        View view = this.M;
        if (view != null && (view instanceof o)) {
            ((o) view).resumeTimers();
        }
        this.aq = false;
        if (this.ar != null || (aVar = this.ao) == null) {
            return;
        }
        aVar.a();
        com.sigmob.sdk.base.views.v vVar = this.ap;
        if (vVar != null) {
            vVar.a();
        }
    }

    @Override // com.sigmob.sdk.base.common.j
    public void h() {
        try {
            SigmobLog.d("VideoViewController onDestroy() called");
            com.sigmob.sdk.base.common.h.g().b(this);
            if (!this.aa) {
                a(IntentActions.ACTION_INTERSTITIAL_DISMISS);
            }
            if (this.ax != null) {
                com.sigmob.sdk.base.common.h.d().unregisterCacheListener(this, this.ax);
            }
            w wVar = this.an;
            if (wVar != null) {
                wVar.setOnClickListener(null);
                ViewUtil.removeFromParent(this.an);
            }
            w wVar2 = this.am;
            if (wVar2 != null) {
                wVar2.setOnClickListener(null);
                ViewUtil.removeFromParent(this.am);
            }
            com.sigmob.sdk.nativead.b bVar = this.ar;
            if (bVar != null) {
                bVar.a((WindNativeAdData.DislikeInteractionCallback) null);
                this.ar.dismiss();
                this.ar.b();
            }
            this.I.k();
            ImageLoader.ImageContainer imageContainer = this.ae;
            if (imageContainer != null) {
                imageContainer.cancelRequest();
                this.ae = null;
            }
            v vVar = this.N;
            if (vVar != null) {
                vVar.a();
                this.N = null;
            }
            MediaMetadataRetriever mediaMetadataRetriever = this.O;
            if (mediaMetadataRetriever != null) {
                mediaMetadataRetriever.release();
            }
            ar arVar = this.Q;
            if (arVar != null) {
                arVar.setOnTouchListener(null);
            }
            w wVar3 = this.R;
            if (wVar3 != null) {
                wVar3.setOnTouchListener(null);
            }
            ar arVar2 = this.ab;
            if (arVar2 != null) {
                arVar2.setOnTouchListener(null);
            }
            com.sigmob.sdk.videoplayer.a aVar = this.K;
            if (aVar != null) {
                aVar.r();
            }
            View view = this.M;
            if (view != null && (view instanceof o)) {
                ((o) view).setWebViewClickListener(null);
                ((o) this.M).setLogoClickListener(null);
                ((o) this.M).destroy();
            }
            U();
            am.a aVar2 = this.ao;
            if (aVar2 != null) {
                aVar2.c();
                this.ao = null;
            }
            BaseAdUnit baseAdUnit = this.L;
            if (baseAdUnit != null) {
                baseAdUnit.destroy();
            }
            this.M = null;
            this.P = null;
            super.h();
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
        }
    }

    @Override // com.sigmob.sdk.base.common.j
    public void i() {
    }

    @Override // com.sigmob.sdk.base.common.j
    public boolean j() {
        return false;
    }

    @Override // com.sigmob.sdk.base.common.j
    public void o() {
    }

    @Override // com.sigmob.sdk.base.common.ac
    public void onAdClick(boolean isRecord, com.sigmob.sdk.base.a type) {
        v vVarR;
        int currentPositionWhenPlaying;
        String str;
        this.az = true;
        W();
        if (isRecord) {
            ClickCommon clickCommon = this.L.getClickCommon();
            int i2 = AnonymousClass7.b[type.ordinal()];
            if (i2 == 1) {
                ad.a(com.sigmob.sdk.base.a.COMPANION, "click", this.L, clickCommon.isDeeplink, clickCommon.clickUrl, clickCommon.clickCoordinate, y(), (JSONObject) null);
                vVarR = r();
                currentPositionWhenPlaying = (int) this.K.getCurrentPositionWhenPlaying();
                str = com.sigmob.sdk.base.common.a.s;
            } else if (i2 == 2) {
                ad.a(com.sigmob.sdk.base.a.VIDEO_CLICK, "click", this.L, clickCommon.isDeeplink, clickCommon.clickUrl, clickCommon.clickCoordinate, y(), (JSONObject) null);
                vVarR = r();
                currentPositionWhenPlaying = (int) this.K.getCurrentPositionWhenPlaying();
                str = com.sigmob.sdk.base.common.a.t;
            } else if (i2 != 3) {
                ad.a(com.sigmob.sdk.base.a.ENDCARD, "click", this.L, clickCommon.isDeeplink, clickCommon.clickUrl, clickCommon.clickCoordinate, y(), (JSONObject) null);
                vVarR = r();
                currentPositionWhenPlaying = (int) this.K.getCurrentPositionWhenPlaying();
                str = "click";
            } else {
                vVarR = r();
                currentPositionWhenPlaying = (int) this.K.getCurrentPositionWhenPlaying();
                str = com.sigmob.sdk.base.common.a.i;
            }
            vVarR.a(str, currentPositionWhenPlaying);
        }
    }

    public void q() {
        com.sigmob.sdk.base.views.b bVar = new com.sigmob.sdk.base.views.b(l().getApplicationContext(), 0);
        this.q = bVar;
        bVar.setId(ClientMetadata.generateViewId());
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-2, Dips.dipsToIntPixels(16.0f, l()));
        com.sigmob.sdk.base.views.m mVar = this.af;
        if (mVar != null) {
            layoutParams.addRule(8, mVar.getId());
        } else {
            layoutParams.addRule(12);
            layoutParams.setMargins(0, 0, 0, this.p);
        }
        try {
            this.q.a(this.L.getAd_source_logo());
            if (!this.L.getInvisibleAdLabel()) {
                this.q.b(com.sigmob.sdk.base.k.h());
            }
        } catch (Throwable unused) {
        }
        m().addView(this.q, layoutParams);
    }

    public v r() {
        if (this.N == null) {
            v vVar = new v();
            this.N = vVar;
            vVar.a(a());
        }
        return this.N;
    }

    public String s() {
        return this.F;
    }

    public boolean t() {
        try {
            long currentPositionWhenPlaying = (int) this.K.getCurrentPositionWhenPlaying();
            if (this.L.getSkipSeconds() > -1) {
                return (((float) currentPositionWhenPlaying) / 1000.0f) + 0.3f >= ((float) this.L.getSkipSeconds());
            }
            if (y() > 0) {
                return ((((float) y()) / 1000.0f) * ((float) this.L.getSkipPercent())) * 0.01f < ((float) currentPositionWhenPlaying) / 1000.0f;
            }
            return true;
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
        }
    }

    /* JADX WARN: Code duplicated, block: B:10:0x002f  */
    public boolean u() {
        boolean z = true;
        try {
            if (this.L.getAd_type() != 1) {
                return false;
            }
            long currentPositionWhenPlaying = (int) this.K.getCurrentPositionWhenPlaying();
            int chargeSeconds = this.L.getChargeSeconds();
            int chargePercent = this.L.getChargePercent();
            if (chargeSeconds > -1) {
                if ((currentPositionWhenPlaying / 1000.0f) + 0.3f < chargeSeconds) {
                    z = false;
                }
            } else {
                if (y() <= 0) {
                    return false;
                }
                if ((currentPositionWhenPlaying * 100) / ((long) y()) < chargePercent) {
                    z = false;
                }
            }
            return z;
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
            return true;
        }
    }

    public boolean v() {
        com.sigmob.sdk.base.views.m mVar = this.af;
        if (mVar != null && mVar.a()) {
            return true;
        }
        try {
            boolean z = ((long) ((int) this.K.getCurrentPositionWhenPlaying())) / 1000 >= ((long) this.G);
            if (z) {
                SigmobLog.d("showAble CompanionAds");
            }
            return z;
        } catch (Throwable th) {
            SigmobLog.e("shouldBeShowCompanionAds", th);
            return true;
        }
    }

    public void w() {
        com.sigmob.sdk.base.views.m mVar;
        if (this.H || (mVar = this.af) == null) {
            return;
        }
        mVar.setVisibility(0);
        this.H = true;
    }

    public void x() {
        if (this.av) {
            return;
        }
        this.av = true;
        this.L.getMacroCommon().addMarcoKey(SigMacroCommon._PLAYLASTFRAME_, "1");
        if (this.W) {
            return;
        }
        r().a("complete", (int) this.K.getCurrentPositionWhenPlaying());
    }

    int y() {
        com.sigmob.sdk.videoplayer.a aVar = this.K;
        if (aVar == null) {
            return 0;
        }
        int i2 = this.X;
        return i2 > 0 ? this.I.b(i2) : this.I.b((int) aVar.getDuration());
    }

    void z() {
        if (this.M == null && this.L.isEndCardIndexExist()) {
            try {
                f fVarE = com.sigmob.sdk.videoAd.a.e(this.L);
                this.S = fVarE;
                fVarE.a(this.I);
                this.M = a(n(), this.S, 4);
                this.S.a(y());
                h(l(), 4);
            } catch (Throwable th) {
                this.S = null;
                SigmobLog.e(th.getMessage());
                HashMap map = new HashMap();
                map.put("error", th.getMessage());
                a(IntentActions.ACTION_REWARDED_VIDEO_PLAYFAIL, map);
                this.d.a();
            }
        }
    }
}
