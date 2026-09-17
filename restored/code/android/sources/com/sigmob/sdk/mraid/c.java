package com.sigmob.sdk.mraid;

import android.content.Context;
import android.graphics.Rect;
import android.location.Location;
import android.net.Uri;
import android.view.View;
import android.webkit.ConsoleMessage;
import android.webkit.JsPromptResult;
import android.webkit.JsResult;
import android.webkit.RenderProcessGoneDetail;
import android.webkit.ValueCallback;
import android.webkit.WebChromeClient;
import android.webkit.WebResourceError;
import android.webkit.WebResourceRequest;
import android.webkit.WebResourceResponse;
import android.webkit.WebSettings;
import android.webkit.WebView;
import androidx.core.app.NotificationCompat;
import com.bykv.vk.component.ttvideo.log.LiveError;
import com.bykv.vk.component.ttvideo.player.MediaFormat;
import com.bytedance.pangle.provider.ContentProviderManager;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.json.JSONSerializer;
import com.czhj.sdk.common.network.Networking;
import com.czhj.sdk.common.utils.Md5Util;
import com.czhj.sdk.common.utils.TouchLocation;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.sdk.logger.SigmobLogger;
import com.czhj.volley.toolbox.StringUtil;
import com.sigmob.sdk.base.BaseAdActivity;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.common.aq;
import com.sigmob.sdk.base.models.AppInfo;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.ClickCommon;
import com.sigmob.sdk.base.models.CurrentAppOrientation;
import com.sigmob.sdk.base.models.ExposureChange;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.MraidEnv;
import com.sigmob.sdk.base.models.PlacementType;
import com.sigmob.sdk.base.models.VideoItem;
import com.sigmob.sdk.base.models.ViewState;
import com.sigmob.sdk.base.models.rtb.Ad;
import com.sigmob.sdk.base.models.rtb.AdSetting;
import com.sigmob.sdk.base.models.rtb.MaterialMeta;
import com.sigmob.sdk.base.models.rtb.RvAdSetting;
import com.sigmob.sdk.base.models.rtb.SlotAdSetting;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.WindAdRequest;
import com.tencent.bugly.BuglyStrategy;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.net.URI;
import java.net.URISyntaxException;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3482a = "MraidBridge";
    static final String b = "mraid://open?url=";
    BaseAdUnit c;
    d d;
    v e;
    private final PlacementType f;
    private final m g;
    private String h;
    private aq i;
    private boolean j;
    private final w k;
    private e l;

    /* JADX INFO: renamed from: com.sigmob.sdk.mraid.c$3, reason: invalid class name */
    static /* synthetic */ class AnonymousClass3 {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f3484a;

        static {
            int[] iArr = new int[k.values().length];
            f3484a = iArr;
            try {
                iArr[k.CLOSE.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                f3484a[k.UNLOAD.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                f3484a[k.OPENFOURELEMENTS.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            try {
                f3484a[k.RESIZE.ordinal()] = 4;
            } catch (NoSuchFieldError unused4) {
            }
            try {
                f3484a[k.EXPAND.ordinal()] = 5;
            } catch (NoSuchFieldError unused5) {
            }
            try {
                f3484a[k.USE_CUSTOM_CLOSE.ordinal()] = 6;
            } catch (NoSuchFieldError unused6) {
            }
            try {
                f3484a[k.OPEN.ordinal()] = 7;
            } catch (NoSuchFieldError unused7) {
            }
            try {
                f3484a[k.feedBack.ordinal()] = 8;
            } catch (NoSuchFieldError unused8) {
            }
            try {
                f3484a[k.SET_ORIENTATION_PROPERTIES.ordinal()] = 9;
            } catch (NoSuchFieldError unused9) {
            }
            try {
                f3484a[k.PLAY_VIDEO.ordinal()] = 10;
            } catch (NoSuchFieldError unused10) {
            }
            try {
                f3484a[k.STORE_PICTURE.ordinal()] = 11;
            } catch (NoSuchFieldError unused11) {
            }
            try {
                f3484a[k.CREATE_CALENDAR_EVENT.ordinal()] = 12;
            } catch (NoSuchFieldError unused12) {
            }
            try {
                f3484a[k.VPAID.ordinal()] = 13;
            } catch (NoSuchFieldError unused13) {
            }
            try {
                f3484a[k.EXTENSION.ordinal()] = 14;
            } catch (NoSuchFieldError unused14) {
            }
            try {
                f3484a[k.UNSPECIFIED.ordinal()] = 15;
            } catch (NoSuchFieldError unused15) {
            }
        }
    }

    c(BaseAdUnit adUnit, PlacementType placementType) {
        this(adUnit, placementType, new m());
    }

    c(BaseAdUnit adUnit, PlacementType placementType, m mraidNativeCommandHandler) {
        this.k = new w() { // from class: com.sigmob.sdk.mraid.c.1
            @Override // android.webkit.WebViewClient
            public void onPageFinished(WebView view, String url) {
                c.this.o();
            }

            @Override // android.webkit.WebViewClient
            public void onReceivedError(WebView view, int errorCode, String description, String failingUrl) {
                ad.a("h5_error", "mraid1", errorCode, failingUrl + " error:" + description, (WindAdRequest) null, (LoadAdRequest) null, c.this.c, (ad.a) null);
            }

            @Override // android.webkit.WebViewClient
            public void onReceivedError(WebView view, WebResourceRequest request, WebResourceError error) {
                SigmobLog.i("onReceivedError:" + error.toString());
                ad.a("h5_error", "mraid1", 0, request.getUrl() + " error:" + ((Object) error.getDescription()), (WindAdRequest) null, (LoadAdRequest) null, c.this.c, (ad.a) null);
            }

            @Override // android.webkit.WebViewClient
            public void onReceivedHttpError(WebView view, WebResourceRequest request, WebResourceResponse errorResponse) {
                ad.a("h5_error", "mraid1", errorResponse.getStatusCode(), request.getUrl().toString(), (WindAdRequest) null, (LoadAdRequest) null, c.this.c, (ad.a) null);
            }

            @Override // android.webkit.WebViewClient
            public boolean onRenderProcessGone(final WebView view, final RenderProcessGoneDetail detail) {
                c.this.a(detail);
                return true;
            }

            @Override // com.sigmob.sdk.mraid.w, com.sigmob.sdk.base.l, android.webkit.WebViewClient
            public WebResourceResponse shouldInterceptRequest(WebView view, String url) {
                if (com.sigmob.sdk.base.utils.x.a(url)) {
                    return null;
                }
                String videoPath = c.this.c.getVideoPath();
                boolean zIsVideoExist = c.this.c.isVideoExist();
                if (com.sigmob.sdk.base.utils.s.b(videoPath) && url.endsWith(videoPath) && zIsVideoExist) {
                    try {
                        return new WebResourceResponse("video/mp4", "UTF-8", new FileInputStream(videoPath));
                    } catch (FileNotFoundException e) {
                        SigmobLog.e(e.getMessage());
                    }
                }
                return super.shouldInterceptRequest(view, url);
            }

            @Override // android.webkit.WebViewClient
            public boolean shouldOverrideUrlLoading(WebView view, String url) {
                return c.this.a(view, url);
            }
        };
        this.c = adUnit;
        this.f = placementType;
        this.g = mraidNativeCommandHandler;
    }

    private int a(int value, int min, int max) throws f {
        if (value < min || value > max) {
            throw new f("Integer parameter out of range: " + value);
        }
        return value;
    }

    private b.a a(String text, b.a defaultValue) throws f {
        if (com.sigmob.sdk.base.utils.s.a((CharSequence) text)) {
            return defaultValue;
        }
        text.hashCode();
        switch (text) {
            case "center":
                return b.a.CENTER;
            case "top-right":
                return b.a.TOP_RIGHT;
            case "top-left":
                return b.a.TOP_LEFT;
            case "bottom-left":
                return b.a.BOTTOM_LEFT;
            case "bottom-right":
                return b.a.BOTTOM_RIGHT;
            case "bottom-center":
                return b.a.BOTTOM_CENTER;
            case "top-center":
                return b.a.TOP_CENTER;
            default:
                throw new f("Invalid close position: " + text);
        }
    }

    private String a(Rect rect) {
        return rect.left + "," + rect.top + "," + rect.width() + "," + rect.height();
    }

    public static String a(String value) {
        if (value == null || value.equalsIgnoreCase("null") || value.equalsIgnoreCase("undefined")) {
            return null;
        }
        return value;
    }

    private URI a(String encodedText, URI defaultValue) throws f {
        return encodedText == null ? defaultValue : i(encodedText);
    }

    private void a(k command) {
        c("window.mraidbridge.nativeCallComplete(" + JSONObject.quote(command.a()) + ")");
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(k kVar, f fVar) {
        a(kVar, fVar.getMessage());
    }

    private void a(k command, String message) {
        c("window.mraidbridge.notifyErrorEvent(" + JSONObject.quote(command.a()) + ", " + JSONObject.quote(message) + ")");
    }

    private boolean a(String text, boolean defaultValue) throws f {
        return text == null ? defaultValue : h(text);
    }

    private String b(Rect rect) {
        return rect.width() + "," + rect.height();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(boolean z) {
        d dVar = this.d;
        if (dVar == null) {
            return;
        }
        dVar.a(z);
    }

    private URI c(String encodedText, String defaultValue) throws f {
        try {
            try {
                return encodedText == null ? new URI(defaultValue) : new URI(encodedText);
            } catch (URISyntaxException unused) {
                return new URI(defaultValue);
            }
        } catch (URISyntaxException unused2) {
            throw new f("Invalid URL parameter: " + encodedText);
        }
    }

    private int f(String text) throws f {
        try {
            return Integer.parseInt(text, 10);
        } catch (NumberFormatException unused) {
            throw new f("Invalid numeric parameter: " + text);
        }
    }

    private p g(String text) throws f {
        if ("portrait".equals(text)) {
            return p.PORTRAIT;
        }
        if ("landscape".equals(text)) {
            return p.LANDSCAPE;
        }
        if ("none".equals(text)) {
            return p.NONE;
        }
        throw new f("Invalid orientation: " + text);
    }

    private boolean h(String text) throws f {
        if ("true".equals(text)) {
            return true;
        }
        if ("false".equals(text)) {
            return false;
        }
        throw new f("Invalid boolean parameter: " + text);
    }

    private URI i(String encodedText) throws f {
        if (encodedText == null) {
            throw new f("Parameter cannot be null");
        }
        try {
            return new URI(encodedText);
        } catch (URISyntaxException unused) {
            throw new f("Invalid URL parameter: " + encodedText);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void o() {
        if (this.j) {
            return;
        }
        this.j = true;
        d dVar = this.d;
        if (dVar != null) {
            dVar.a();
        }
    }

    public String a() {
        return this.h;
    }

    void a(int process) {
        c("bridge.notifyApkDownloadProcessEvent(" + process + ");");
    }

    void a(int top, int left, int bottom, int right) {
        c("mraidbridge.setSafeAreaInsets(" + (top + "," + left + "," + bottom + "," + right) + ")");
    }

    public void a(Context context, String htmlData) {
        v vVar = this.e;
        if (vVar == null) {
            SigmobLog.e("MRAID bridge called setContentHtml before WebView was attached");
            return;
        }
        vVar.addJavascriptInterface(new a(this), "sigandroid");
        this.j = false;
        File fileB = com.sigmob.sdk.base.utils.n.b(htmlData, Md5Util.md5(htmlData) + ".html");
        if (fileB == null || com.sigmob.sdk.base.utils.s.a((CharSequence) fileB.getAbsolutePath())) {
            this.e.loadDataWithBaseURL(Networking.getBaseUrlScheme() + "://localhost/", htmlData, "text/html", "UTF-8", null);
        } else {
            this.e.loadUrl("file://" + fileB.getAbsolutePath());
        }
    }

    public void a(Location location) {
        c("mraidbridge.setLocation(" + location.getLatitude() + "," + location.getLongitude() + ",\"" + location.getProvider() + "\");");
    }

    void a(RenderProcessGoneDetail detail) {
        WindAdError windAdError = (detail == null || !detail.didCrash()) ? WindAdError.RENDER_PROCESS_GONE_UNSPECIFIED : WindAdError.RENDER_PROCESS_GONE_WITH_CRASH;
        SigmobLog.e("handleRenderProcessGone " + windAdError);
        b();
        d dVar = this.d;
        if (dVar != null) {
            dVar.a(windAdError);
        }
    }

    void a(ValueCallback callback) {
        a("mraidbridge.getPlayProgress();", callback);
    }

    void a(AppInfo appInfo) {
        c("bridge.fireChangeEvent({" + appInfo.toString().replace("=", ":") + "});");
    }

    void a(CurrentAppOrientation appOrientation) {
        c("mraidbridge.fireChangeEvent({" + appOrientation.toString().replace("=", ":") + "});");
    }

    void a(ExposureChange exposedProperty) {
        c("mraidbridge.fireChangeEvent({" + exposedProperty.toString().replace("=", ":") + "});");
    }

    void a(MraidEnv env) {
        c("mraidbridge.fireChangeEvent(" + JSONSerializer.Serialize(env, "env", true) + ");");
    }

    void a(PlacementType placementType) {
        c("mraidbridge.setPlacementType(" + JSONObject.quote(placementType.toJavascriptString()) + ")");
    }

    void a(VideoItem videoItem) {
        c("bridge.fireChangeEvent(" + JSONSerializer.Serialize(videoItem, "video", false) + ");");
    }

    void a(ViewState state) {
        c("mraidbridge.setState(" + JSONObject.quote(state.toJavascriptString()) + ")");
    }

    void a(Ad ad, SlotAdSetting adSetting) {
        String strSerialize = JSONSerializer.Serialize(ad, ClickCommon.CLICK_SCENE_AD, true);
        try {
            String strSerialize2 = JSONSerializer.Serialize(adSetting, null, true);
            JSONObject jSONObject = new JSONObject(strSerialize);
            jSONObject.getJSONObject(ClickCommon.CLICK_SCENE_AD).put("slotAdSetting", new JSONObject(strSerialize2));
            c("bridge.fireChangeEvent(" + jSONObject.toString() + ");");
        } catch (JSONException e) {
            throw new RuntimeException(e);
        }
    }

    void a(MaterialMeta materialMeta) {
        c("bridge.fireChangeEvent(" + JSONSerializer.Serialize(materialMeta, ClickCommon.CLICK_AREA_MATERIAL, true) + ");");
    }

    void a(RvAdSetting rvAdSetting) {
        c("bridge.fireChangeEvent(" + JSONSerializer.Serialize(rvAdSetting, "rvSetting", false) + ");");
    }

    void a(d listener) {
        this.d = listener;
    }

    void a(e listener) {
        this.l = listener;
    }

    void a(final k command, Map<String, String> params) throws f {
        if (this.d == null) {
            throw new f("Invalid state to execute this command.");
        }
        if (this.e == null) {
            throw new f("The current WebView is being destroyed.");
        }
        switch (AnonymousClass3.f3484a[command.ordinal()]) {
            case 1:
                this.d.d();
                return;
            case 2:
                this.d.e();
                return;
            case 3:
                this.d.f();
                return;
            case 4:
                this.d.a(a(f(params.get(MediaFormat.KEY_WIDTH)), 0, BuglyStrategy.a.MAX_USERDATA_VALUE_LENGTH), a(f(params.get(MediaFormat.KEY_HEIGHT)), 0, BuglyStrategy.a.MAX_USERDATA_VALUE_LENGTH), a(f(params.get("offsetX")), LiveError.PARSE_JSON, BuglyStrategy.a.MAX_USERDATA_VALUE_LENGTH), a(f(params.get("offsetY")), LiveError.PARSE_JSON, BuglyStrategy.a.MAX_USERDATA_VALUE_LENGTH), a(params.get("customClosePosition"), b.a.TOP_RIGHT), a(params.get("allowOffscreen"), true));
                return;
            case 5:
                this.d.a(a(params.get("url"), (URI) null), a(params.get("shouldUseCustomClose"), false));
                return;
            case 6:
                this.d.b(a(params.get("shouldUseCustomClose"), false));
                return;
            case 7:
                SigmobLogger.d(f3482a, "runCommand: command = " + command.a(), new Object[0]);
                this.d.a(c(params.get("url"), ""), 1, a(params.get(com.sigmob.sdk.base.n.m)));
                return;
            case 8:
                this.d.g();
                return;
            case 9:
                this.d.a(h(params.get("allowOrientationChange")), g(params.get("forceOrientation")));
                return;
            case 10:
                this.d.a(i(params.get(ContentProviderManager.PROVIDER_URI)));
                return;
            case 11:
                this.g.a(this.e.getContext(), i(params.get(ContentProviderManager.PROVIDER_URI)).toString(), new m.a() { // from class: com.sigmob.sdk.mraid.c$$ExternalSyntheticLambda0
                    @Override // com.sigmob.sdk.mraid.m.a
                    public final void onFailure(f fVar) {
                        this.f$0.a(command, fVar);
                    }
                });
                return;
            case 12:
                this.g.a(this.e.getContext(), params);
                return;
            case 13:
                this.d.a(params.get(NotificationCompat.CATEGORY_EVENT), params);
                return;
            case 14:
                this.d.b(params.get(NotificationCompat.CATEGORY_EVENT), params);
                return;
            case 15:
                throw new f("Unspecified MRAID Javascript command");
            default:
                return;
        }
    }

    public void a(final q screenMetrics) {
        c("mraidbridge.setScreenSize(" + b(screenMetrics.c()) + ");mraidbridge.setMaxSize(" + b(screenMetrics.e()) + ");mraidbridge.setCurrentPosition(" + a(screenMetrics.g()) + ");mraidbridge.setDefaultPosition(" + a(screenMetrics.i()) + ")");
        c("mraidbridge.notifySizeChangeEvent(" + b(screenMetrics.g()) + ")");
    }

    public void a(v mraidWebView) {
        this.e = mraidWebView;
        WebSettings settings = mraidWebView.getSettings();
        com.sigmob.sdk.base.utils.j.a(f3482a, settings);
        if (this.f == PlacementType.INTERSTITIAL) {
            settings.setMediaPlaybackRequiresUserGesture(false);
        }
        this.k.b(this.c.isDisablexRequestWith());
        this.k.a(com.sigmob.sdk.base.o.a().ad());
        this.e.setScrollContainer(false);
        this.e.setVerticalScrollBarEnabled(false);
        this.e.setHorizontalScrollBarEnabled(false);
        this.e.setBackgroundColor(0);
        this.e.setAdUnit(this.c);
        this.e.a((com.sigmob.sdk.base.common.b) null);
        this.e.setWebViewClient(this.k);
        this.e.setWebChromeClient(new WebChromeClient() { // from class: com.sigmob.sdk.mraid.c.2
            @Override // android.webkit.WebChromeClient
            public boolean onConsoleMessage(ConsoleMessage consoleMessage) {
                return c.this.d == null ? super.onConsoleMessage(consoleMessage) : c.this.d.a(consoleMessage);
            }

            @Override // android.webkit.WebChromeClient
            public boolean onJsAlert(WebView view, String url, String message, JsResult result) {
                return c.this.d == null ? super.onJsAlert(view, url, message, result) : c.this.d.a(message, result);
            }

            @Override // android.webkit.WebChromeClient
            public boolean onJsPrompt(WebView view, String url, String message, String defaultValue, JsPromptResult result) {
                return super.onJsPrompt(view, url, message, defaultValue, result);
            }

            @Override // android.webkit.WebChromeClient
            public void onShowCustomView(View view, WebChromeClient.CustomViewCallback callback) {
                super.onShowCustomView(view, callback);
            }
        });
        this.i = new aq(this.e.getContext(), this.e, this.c);
        this.e.setVisibilityChangedListener(new v.a() { // from class: com.sigmob.sdk.mraid.c$$ExternalSyntheticLambda1
            @Override // com.sigmob.sdk.mraid.v.a
            public final void onVisibilityChanged(boolean z) {
                this.f$0.b(z);
            }
        });
    }

    public void a(String uniqueId, int position) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("uniqueId", uniqueId);
            jSONObject.put("currentTime", position / 1000.0f);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        c("mraidbridge.setvdPlayToEnd(" + jSONObject + ")");
    }

    public void a(String uniqueId, int position, int duration) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("uniqueId", uniqueId);
            jSONObject.put("currentTime", position / 1000.0f);
            jSONObject.put(MediationConstant.EXTRA_DURATION, duration / 1000.0f);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        c("mraidbridge.setvdPlayCurrentTime(" + jSONObject + ")");
    }

    void a(String uniqueId, int duration, int width, int height) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("uniqueId", uniqueId);
            jSONObject.put(MediationConstant.EXTRA_DURATION, duration / 1000.0f);
            jSONObject.put(MediaFormat.KEY_WIDTH, width);
            jSONObject.put(MediaFormat.KEY_HEIGHT, height);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        c("mraidbridge.setvdReadyToPlay(" + jSONObject + ")");
    }

    void a(String javascript, ValueCallback callback) {
        if (this.e == null) {
            SigmobLog.e("Attempted to inject Javascript into MRAID WebView while was not attached:\n\t" + javascript);
            return;
        }
        if (javascript.startsWith("bridge")) {
            javascript = javascript.replaceFirst("bridge", StringUtil.decode(StringUtil.s));
        }
        SigmobLog.d("Injecting Javascript into MRAID WebView:\n\t" + javascript);
        this.e.evaluateJavascript(javascript, callback);
    }

    void a(String x, String y) {
        this.h = String.format("%s,%s,%s,%s", x, y, x, y);
        this.c.getMacroCommon().updateClickMarco(x, y, x, y);
        this.c.getClickCommon().down = new TouchLocation(Integer.parseInt(x), Integer.parseInt(y));
        this.c.getClickCommon().up = new TouchLocation(Integer.parseInt(x), Integer.parseInt(y));
    }

    void a(String uniqueId, String type, String event, HashMap<String, Object> args) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put(NotificationCompat.CATEGORY_EVENT, event);
            jSONObject2.put("uniqueId", uniqueId);
            if (args != null) {
                jSONObject2.put("args", new JSONObject(args));
            }
            jSONObject.put("onChangeFired", jSONObject2);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        c("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    public void a(String event, String subEvent, JSONObject args) {
        if (this.l == null) {
        }
        event.hashCode();
        switch (event) {
            case "motion":
                this.l.d(subEvent, args);
                break;
            case "motionView":
                this.l.e(subEvent, args);
                break;
            case "addSubview":
                this.l.c(subEvent, args);
                break;
            case "vpaid":
                this.l.a(subEvent, args);
                break;
            case "belowSubview":
                this.l.b(subEvent, args);
                break;
        }
    }

    void a(String event, HashMap<String, Object> args) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put(NotificationCompat.CATEGORY_EVENT, event);
            if (args != null) {
                jSONObject2.put("args", new JSONObject(args));
            }
            jSONObject.put("onChangeEvent", jSONObject2);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        c("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    void a(boolean isViewable) {
        c("mraidbridge.setIsViewable(" + isViewable + ")");
    }

    void a(boolean sms, boolean telephone, boolean calendar, boolean storePicture, boolean inlineVideo, boolean vpaid, boolean location) {
        c("mraidbridge.setSupports(" + sms + "," + telephone + "," + calendar + "," + storePicture + "," + inlineVideo + "," + vpaid + "," + location + ")");
    }

    boolean a(WebView view, String url) {
        int i;
        d dVar;
        SigmobLog.d("MraidBridge#handleShouldOverrideUrl: url = " + url);
        try {
            new URI(url);
            Uri uri = Uri.parse(url);
            String scheme = uri.getScheme();
            String host = uri.getHost();
            if (StringUtil.decode(StringUtil.s).equals(scheme)) {
                if ("failLoad".equals(host) && this.f == PlacementType.INLINE && (dVar = this.d) != null) {
                    dVar.c();
                }
                return true;
            }
            if (BaseAdActivity.c.equals(scheme)) {
                SigmobLogger.d(f3482a, "handleShouldOverrideUrl: uri = " + uri, new Object[0]);
                k kVarA = k.a(host);
                try {
                    a(kVarA, ClientMetadata.getQueryParamMap(uri));
                } catch (Throwable th) {
                    a(kVarA, th.getMessage());
                }
                a(kVarA);
                return true;
            }
            if (com.sigmob.sdk.base.utils.s.b(url)) {
                if (url.startsWith("http")) {
                    view.loadUrl(url);
                } else {
                    try {
                        AdSetting adSetting = this.c.getAdSetting();
                        List<String> list = adSetting == null ? null : adSetting.scheme_white_list;
                        if (com.sigmob.sdk.base.utils.f.a(list)) {
                            return true;
                        }
                        while (i < list.size()) {
                            String str = list.get(i);
                            i = (url.startsWith(str) || str.equals("*")) ? 0 : i + 1;
                            com.sigmob.sdk.base.utils.h.a(this.e.getContext(), Uri.parse(url));
                            return true;
                        }
                    } catch (Exception e) {
                        e.printStackTrace();
                    }
                }
            }
            return true;
        } catch (URISyntaxException unused) {
            SigmobLog.e("Invalid MRAID URL: " + url);
            a(k.UNSPECIFIED, "Mraid command sent an invalid URL");
            return true;
        }
    }

    void b() {
        this.d = null;
        this.l = null;
        v vVar = this.e;
        if (vVar == null) {
            return;
        }
        vVar.destroy();
        this.e = null;
    }

    void b(ValueCallback callback) {
        a("mraidbridge.getAdDuration();", callback);
    }

    public void b(String url) {
        v vVar = this.e;
        if (vVar == null) {
            SigmobLog.e("MRAID bridge called setContentHtml while WebView was not attached");
            return;
        }
        vVar.addJavascriptInterface(new a(this), "sigandroid");
        this.j = false;
        this.e.loadUrl(url);
    }

    public void b(String uniqueId, int state) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("uniqueId", uniqueId);
            jSONObject.put("state", state);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        c("mraidbridge.setvdLoadStateChanged(" + jSONObject + ")");
    }

    public void b(String uniqueId, String error) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("uniqueId", uniqueId);
            jSONObject.put("error", error);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        c("mraidbridge.setvdPlayError(" + jSONObject + ")");
    }

    void c() {
        c("bridge.fireChangeEvent({\"osType\":2});");
    }

    void c(String javascript) {
        if (this.e == null) {
            SigmobLog.e("Attempted to inject Javascript into MRAID WebView while was not attached:\n\t" + javascript);
            return;
        }
        if (javascript.startsWith("bridge")) {
            javascript = javascript.replaceFirst("bridge", StringUtil.decode(StringUtil.s));
        }
        SigmobLog.d("Injecting Javascript into MRAID WebView:\n\t" + javascript);
        this.e.evaluateJavascript(javascript, null);
    }

    public void c(String uniqueId, int state) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("uniqueId", uniqueId);
            jSONObject.put("state", state);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        c("mraidbridge.setvdPlayStateChanged(" + jSONObject + ")");
    }

    void d() {
        c("mraidbridge.fireChangeEvent({\"hostSDKVersion\":4.25.14});");
    }

    void d(String url) {
        c("mraidbridge.fireVideoSrc(\"" + url + "\")");
    }

    void e() {
        c("mraidbridge.notifyReadyEvent();");
    }

    void e(String cmd) {
        c("mraidbridge.nativeCallCompleteV2(" + JSONObject.quote(cmd) + ")");
    }

    void f() {
        c("bridge.notifyApkDownloadStartEvent();");
    }

    void g() {
        c("bridge.notifyApkDownloadFailEvent();");
    }

    void h() {
        c("bridge.notifyApkDownloadEndEvent();");
    }

    void i() {
        c("bridge.notifyApkDownloadInstalledEvent();");
    }

    void j() {
        c("mraidbridge.startAd();");
    }

    boolean k() {
        aq aqVar = this.i;
        return aqVar != null && aqVar.c();
    }

    boolean l() {
        v vVar = this.e;
        return vVar != null && vVar.j();
    }

    boolean m() {
        return this.e != null;
    }

    boolean n() {
        return this.j;
    }
}
