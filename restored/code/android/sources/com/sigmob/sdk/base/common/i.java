package com.sigmob.sdk.base.common;

import android.app.Activity;
import android.content.Context;
import android.net.Uri;
import com.byazt.bv.BaseConstants;
import com.czhj.sdk.common.Constants;
import com.czhj.sdk.common.network.JsonRequest;
import com.czhj.sdk.common.network.Networking;
import com.czhj.sdk.common.network.SigmobRequestQueue;
import com.czhj.sdk.common.utils.FileUtil;
import com.czhj.sdk.common.utils.Preconditions;
import com.czhj.sdk.common.utils.TouchLocation;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.volley.VolleyError;
import com.czhj.wire.Wire;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.ClickCommon;
import com.sigmob.sdk.base.models.SigMacroCommon;
import com.sigmob.sdk.base.models.rtb.AndroidMarket;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import com.sigmob.sdk.base.mta.PointEntitySigmobError;
import java.lang.ref.WeakReference;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class i {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3178a = "i";
    protected Map<String, String> b;
    protected String c;
    protected String d;
    protected String e;
    protected String f;
    protected String g;
    protected String h;
    protected String i;
    public boolean k;
    private boolean m;
    private boolean n;
    private String o;
    private boolean p;
    private ac q;
    private com.sigmob.sdk.base.views.q r;
    private WeakReference<Activity> s;
    private com.sigmob.sdk.base.views.q.b t;
    private WeakReference<BaseAdUnit> u;
    private boolean v;
    private int w;
    protected int j = 1;
    private final List<com.sigmob.sdk.videoAd.d> l = new ArrayList();

    /* JADX INFO: renamed from: com.sigmob.sdk.base.common.i$2, reason: invalid class name */
    class AnonymousClass2 implements JsonRequest.Listener {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ BaseAdUnit f3180a;

        AnonymousClass2(final BaseAdUnit val$adUnit) {
            this.f3180a = val$adUnit;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(Object obj) {
            if (obj instanceof PointEntitySigmobError) {
                ((PointEntitySigmobError) obj).setFinal_url(i.this.o);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b(Object obj) {
            if (obj instanceof PointEntitySigmob) {
                ((PointEntitySigmob) obj).setFinal_url(i.this.o);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void c(Object obj) {
            if (obj instanceof PointEntitySigmobError) {
                ((PointEntitySigmobError) obj).setFinal_url(i.this.o);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void d(Object obj) {
            if (obj instanceof PointEntitySigmob) {
                ((PointEntitySigmob) obj).setFinal_url(i.this.o);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void e(Object obj) {
            if (obj instanceof PointEntitySigmobError) {
                ((PointEntitySigmobError) obj).setFinal_url(i.this.o);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void f(Object obj) {
            if (obj instanceof PointEntitySigmob) {
                ((PointEntitySigmob) obj).setFinal_url(i.this.o);
            }
        }

        @Override // com.czhj.volley.Response.ErrorListener
        public void onErrorResponse(VolleyError error) {
            ad.a("download_start", "0", this.f3180a, new ad.a() { // from class: com.sigmob.sdk.base.common.i$2$$ExternalSyntheticLambda0
                @Override // com.sigmob.sdk.base.common.ad.a
                public final void onAddExtra(Object obj) {
                    this.f$0.b(obj);
                }
            });
            ad.a("download_start", 0, error.getMessage(), this.f3180a, new ad.a() { // from class: com.sigmob.sdk.base.common.i$2$$ExternalSyntheticLambda1
                @Override // com.sigmob.sdk.base.common.ad.a
                public final void onAddExtra(Object obj) {
                    this.f$0.a(obj);
                }
            });
            SigmobLog.e(i.f3178a + "handleFourDownload#onErrorResponse: error = " + error.getMessage());
        }

        @Override // com.czhj.sdk.common.network.JsonRequest.Listener
        public void onSuccess(JSONObject response) {
            try {
                SigmobLog.d(i.f3178a + "handleFourDownload#onSuccess: response = " + response);
                if (response.getInt("ret") == 0) {
                    String string = response.getJSONObject("data").getString("dstlink");
                    this.f3180a.getMacroCommon().addMarcoKey(SigMacroCommon._CLICKID_, response.getJSONObject("data").getString("clickid"));
                    i.this.o = string;
                    q.a(string, this.f3180a);
                } else {
                    ad.a("download_start", "0", this.f3180a, new ad.a() { // from class: com.sigmob.sdk.base.common.i$2$$ExternalSyntheticLambda2
                        @Override // com.sigmob.sdk.base.common.ad.a
                        public final void onAddExtra(Object obj) {
                            this.f$0.f(obj);
                        }
                    });
                    ad.a("download_start", 0, response.toString(), this.f3180a, new ad.a() { // from class: com.sigmob.sdk.base.common.i$2$$ExternalSyntheticLambda3
                        @Override // com.sigmob.sdk.base.common.ad.a
                        public final void onAddExtra(Object obj) {
                            this.f$0.e(obj);
                        }
                    });
                }
            } catch (Throwable th) {
                SigmobLog.e(i.f3178a + "handleFourDownload#onSuccess: error = " + th.getMessage());
                ad.a("download_start", "0", this.f3180a, new ad.a() { // from class: com.sigmob.sdk.base.common.i$2$$ExternalSyntheticLambda4
                    @Override // com.sigmob.sdk.base.common.ad.a
                    public final void onAddExtra(Object obj) {
                        this.f$0.d(obj);
                    }
                });
                ad.a("download_start", 0, th.getMessage(), this.f3180a, new ad.a() { // from class: com.sigmob.sdk.base.common.i$2$$ExternalSyntheticLambda5
                    @Override // com.sigmob.sdk.base.common.ad.a
                    public final void onAddExtra(Object obj) {
                        this.f$0.c(obj);
                    }
                });
            }
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.base.common.i$3, reason: invalid class name */
    class AnonymousClass3 implements JsonRequest.Listener {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ BaseAdUnit f3181a;
        final /* synthetic */ String b;

        AnonymousClass3(final BaseAdUnit val$adUnit, final String val$tempUrl) {
            this.f3181a = val$adUnit;
            this.b = val$tempUrl;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void a(String str, Object obj) {
            if (obj instanceof PointEntitySigmobError) {
                ((PointEntitySigmobError) obj).setFinal_url(str);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void b(String str, Object obj) {
            if (obj instanceof PointEntitySigmob) {
                ((PointEntitySigmob) obj).setFinal_url(str);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void c(String str, Object obj) {
            if (obj instanceof PointEntitySigmobError) {
                ((PointEntitySigmobError) obj).setFinal_url(str);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void d(String str, Object obj) {
            if (obj instanceof PointEntitySigmob) {
                ((PointEntitySigmob) obj).setFinal_url(str);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void e(String str, Object obj) {
            if (obj instanceof PointEntitySigmobError) {
                ((PointEntitySigmobError) obj).setFinal_url(str);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void f(String str, Object obj) {
            if (obj instanceof PointEntitySigmob) {
                ((PointEntitySigmob) obj).setFinal_url(str);
            }
        }

        @Override // com.czhj.volley.Response.ErrorListener
        public void onErrorResponse(VolleyError error) {
            BaseAdUnit baseAdUnit = this.f3181a;
            final String str = this.b;
            ad.a("download_start", "0", baseAdUnit, new ad.a() { // from class: com.sigmob.sdk.base.common.i$3$$ExternalSyntheticLambda4
                @Override // com.sigmob.sdk.base.common.ad.a
                public final void onAddExtra(Object obj) {
                    i.AnonymousClass3.b(str, obj);
                }
            });
            String message = error.getMessage();
            BaseAdUnit baseAdUnit2 = this.f3181a;
            final String str2 = this.b;
            ad.a("download_start", 0, message, baseAdUnit2, new ad.a() { // from class: com.sigmob.sdk.base.common.i$3$$ExternalSyntheticLambda5
                @Override // com.sigmob.sdk.base.common.ad.a
                public final void onAddExtra(Object obj) {
                    i.AnonymousClass3.a(str2, obj);
                }
            });
            SigmobLog.e(i.f3178a + "handleMRAID2Download#onErrorResponse: error = " + error.getMessage());
        }

        @Override // com.czhj.sdk.common.network.JsonRequest.Listener
        public void onSuccess(JSONObject response) {
            try {
                SigmobLog.d(i.f3178a + "handleMRAID2Download#onSuccess: response = " + response);
                if (response.getInt("ret") == 0) {
                    String string = response.getJSONObject("data").getString("dstlink");
                    this.f3181a.getMacroCommon().addMarcoKey(SigMacroCommon._CLICKID_, response.getJSONObject("data").getString("clickid"));
                    q.a(string, this.f3181a);
                } else {
                    BaseAdUnit baseAdUnit = this.f3181a;
                    final String str = this.b;
                    ad.a("download_start", "0", baseAdUnit, new ad.a() { // from class: com.sigmob.sdk.base.common.i$3$$ExternalSyntheticLambda0
                        @Override // com.sigmob.sdk.base.common.ad.a
                        public final void onAddExtra(Object obj) {
                            i.AnonymousClass3.f(str, obj);
                        }
                    });
                    String string2 = response.toString();
                    BaseAdUnit baseAdUnit2 = this.f3181a;
                    final String str2 = this.b;
                    ad.a("download_start", 0, string2, baseAdUnit2, new ad.a() { // from class: com.sigmob.sdk.base.common.i$3$$ExternalSyntheticLambda1
                        @Override // com.sigmob.sdk.base.common.ad.a
                        public final void onAddExtra(Object obj) {
                            i.AnonymousClass3.e(str2, obj);
                        }
                    });
                }
            } catch (Throwable th) {
                SigmobLog.e(i.f3178a + "handleMRAID2Download#onSuccess: error = " + th.getMessage());
                BaseAdUnit baseAdUnit3 = this.f3181a;
                final String str3 = this.b;
                ad.a("download_start", "0", baseAdUnit3, new ad.a() { // from class: com.sigmob.sdk.base.common.i$3$$ExternalSyntheticLambda2
                    @Override // com.sigmob.sdk.base.common.ad.a
                    public final void onAddExtra(Object obj) {
                        i.AnonymousClass3.d(str3, obj);
                    }
                });
                String message = th.getMessage();
                BaseAdUnit baseAdUnit4 = this.f3181a;
                final String str4 = this.b;
                ad.a("download_start", 0, message, baseAdUnit4, new ad.a() { // from class: com.sigmob.sdk.base.common.i$3$$ExternalSyntheticLambda3
                    @Override // com.sigmob.sdk.base.common.ad.a
                    public final void onAddExtra(Object obj) {
                        i.AnonymousClass3.c(str4, obj);
                    }
                });
            }
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.base.common.i$4, reason: invalid class name */
    class AnonymousClass4 implements ao.b {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ BaseAdUnit f3182a;
        final /* synthetic */ boolean b;
        final /* synthetic */ AndroidMarket c;
        final /* synthetic */ boolean d;
        final /* synthetic */ com.sigmob.sdk.base.a e;

        AnonymousClass4(final BaseAdUnit val$baseAdUnit, final boolean val$isRecord, final AndroidMarket val$androidMarket, final boolean val$showAppElement, final com.sigmob.sdk.base.a val$clickUIType) {
            this.f3182a = val$baseAdUnit;
            this.b = val$isRecord;
            this.c = val$androidMarket;
            this.d = val$showAppElement;
            this.e = val$clickUIType;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void a(String str, AndroidMarket androidMarket, Object obj) {
            if (obj instanceof PointEntitySigmob) {
                PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
                pointEntitySigmob.setFinal_url(str);
                Map<String, String> options = pointEntitySigmob.getOptions();
                options.put("app_package_name", androidMarket.app_package_name);
                options.put("store_package_name", androidMarket.appstore_package_name);
                pointEntitySigmob.setOptions(options);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void b(String str, AndroidMarket androidMarket, Object obj) {
            if (obj instanceof PointEntitySigmob) {
                PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
                pointEntitySigmob.setFinal_url(str);
                if (androidMarket == null) {
                    return;
                }
                Map<String, String> options = pointEntitySigmob.getOptions();
                options.put("app_package_name", androidMarket.app_package_name);
                options.put("store_package_name", androidMarket.appstore_package_name);
                pointEntitySigmob.setOptions(options);
            }
        }

        @Override // com.sigmob.sdk.base.common.ao.b
        public void a(final String url, an urlAction) {
            SigmobLog.d(i.f3178a + "urlHandlingSucceeded: action = " + urlAction.name() + ", url = " + url);
            this.f3182a.getClickCommon().is_final_click = true;
            if (!this.f3182a.getAd().forbiden_parse_landingpage.booleanValue()) {
                ad.a(this.f3182a, urlAction.name(), url);
            }
            this.f3182a.getClickCommon().isDeeplink = "0";
            int i = AnonymousClass5.b[urlAction.ordinal()];
            if (i == 3) {
                if (this.b) {
                    com.sigmob.sdk.manager.b.b(this.f3182a, a.G, url);
                }
                this.f3182a.getClickCommon().isDeeplink = "1";
            } else if (i != 5) {
                if (i == 6) {
                    if (this.d && i.this.j()) {
                        this.f3182a.getClickCommon().is_final_click = false;
                    } else {
                        i.this.f(url);
                    }
                }
            } else if (this.b) {
                AndroidMarket androidMarket = this.c;
                if (androidMarket != null) {
                    ad.a(PointCategory.APK_CLICK, ((Integer) Wire.get(androidMarket.type, 0)).intValue() == 0 ? BaseConstants.SCHEME_MARKET : "mimarket", this.f3182a, (ad.a) null);
                    if (com.sigmob.sdk.base.utils.s.b(this.c.app_package_name)) {
                        try {
                            FileUtil.writeToCache(this.f3182a, com.sigmob.sdk.base.utils.n.a((Object) this.c.app_package_name).getAbsolutePath());
                        } catch (Throwable th) {
                            SigmobLog.e(i.f3178a + "urlHandlingSucceeded: error = " + th.getMessage());
                        }
                    }
                }
                BaseAdUnit baseAdUnit = this.f3182a;
                final AndroidMarket androidMarket2 = this.c;
                ad.a(PointCategory.OPEN_MARKET, (String) null, baseAdUnit, new ad.a() { // from class: com.sigmob.sdk.base.common.i$4$$ExternalSyntheticLambda0
                    @Override // com.sigmob.sdk.base.common.ad.a
                    public final void onAddExtra(Object obj) {
                        i.AnonymousClass4.b(url, androidMarket2, obj);
                    }
                });
            }
            this.f3182a.setCustomDeeplink(null);
            this.f3182a.setCustomAndroidMarket(null);
            this.f3182a.setCustomLandPageUrl(null);
            if (i.this.q != null) {
                i.this.q.onAdClick(this.b, this.e);
            }
        }

        @Override // com.sigmob.sdk.base.common.ao.b
        public void b(final String url, an urlAction) {
            SigmobLog.d(i.f3178a + "urlHandlingFailed: action = " + urlAction.name() + ", url = " + url);
            this.f3182a.getClickCommon().isDeeplink = "0";
            int i = AnonymousClass5.b[urlAction.ordinal()];
            if (i == 3 || i == 4) {
                if (this.b) {
                    com.sigmob.sdk.manager.b.b(this.f3182a, a.H, url);
                    return;
                }
                return;
            }
            if (i == 5) {
                if (this.b) {
                    BaseAdUnit baseAdUnit = this.f3182a;
                    final AndroidMarket androidMarket = this.c;
                    ad.a(PointCategory.OPEN_MARKET_FAILED, url, baseAdUnit, new ad.a() { // from class: com.sigmob.sdk.base.common.i$4$$ExternalSyntheticLambda1
                        @Override // com.sigmob.sdk.base.common.ad.a
                        public final void onAddExtra(Object obj) {
                            i.AnonymousClass4.a(url, androidMarket, obj);
                        }
                    });
                    return;
                }
                return;
            }
            if (i != 8) {
                return;
            }
            if (com.sigmob.sdk.base.utils.s.a((CharSequence) url) && !this.f3182a.getAd().forbiden_parse_landingpage.booleanValue()) {
                ad.a(this.f3182a, urlAction.name(), url);
            }
            this.f3182a.setCustomDeeplink(null);
            this.f3182a.setCustomAndroidMarket(null);
            this.f3182a.setCustomLandPageUrl(null);
            if (i.this.q != null) {
                i.this.q.onAdClick(this.b, this.e);
            }
        }
    }

    /* JADX INFO: renamed from: com.sigmob.sdk.base.common.i$5, reason: invalid class name */
    static /* synthetic */ class AnonymousClass5 {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f3183a;
        static final /* synthetic */ int[] b;

        static {
            int[] iArr = new int[an.values().length];
            b = iArr;
            try {
                iArr[an.FOLLOW_PACKAGE_NAME.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                b[an.IGNORE_ABOUT_SCHEME.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                b[an.MINI_PROGRAM.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            try {
                b[an.FOLLOW_DEEP_LINK.ordinal()] = 4;
            } catch (NoSuchFieldError unused4) {
            }
            try {
                b[an.MARKET_SCHEME.ordinal()] = 5;
            } catch (NoSuchFieldError unused5) {
            }
            try {
                b[an.DOWNLOAD_APK.ordinal()] = 6;
            } catch (NoSuchFieldError unused6) {
            }
            try {
                b[an.OPEN_WITH_BROWSER.ordinal()] = 7;
            } catch (NoSuchFieldError unused7) {
            }
            try {
                b[an.NOOP.ordinal()] = 8;
            } catch (NoSuchFieldError unused8) {
            }
            int[] iArr2 = new int[com.sigmob.sdk.base.a.values().length];
            f3183a = iArr2;
            try {
                iArr2[com.sigmob.sdk.base.a.COMPANION.ordinal()] = 1;
            } catch (NoSuchFieldError unused9) {
            }
            try {
                f3183a[com.sigmob.sdk.base.a.VIDEO_CLICK.ordinal()] = 2;
            } catch (NoSuchFieldError unused10) {
            }
        }
    }

    protected i() {
    }

    public static i a(BaseAdUnit adUnit) {
        i iVar = new i();
        iVar.b(adUnit);
        return iVar;
    }

    public static void a(BaseAdUnit adUnit, String url, boolean parse302) {
        final String strMacroProcess = adUnit.getMacroCommon().macroProcess(url);
        String productId = adUnit.getProductId();
        String apkPackageName = adUnit.getApkPackageName();
        int i = adUnit.getsubInteractionType();
        if (i == 2 || com.sigmob.sdk.base.utils.s.b(apkPackageName)) {
            if (!com.sigmob.sdk.base.utils.s.a((CharSequence) apkPackageName)) {
                productId = apkPackageName;
            }
            if (com.sigmob.sdk.base.utils.s.b(productId)) {
                try {
                    h.c(adUnit);
                    com.sigmob.sdk.base.utils.h.c(com.sigmob.sdk.b.e(), productId);
                    return;
                } catch (Throwable th) {
                    h.c((BaseAdUnit) null);
                    SigmobLog.e(f3178a + "handleMRAID2Download: error = " + th.getMessage());
                }
            }
        }
        if (i != 1 || parse302) {
            q.a(strMacroProcess, adUnit);
            return;
        }
        JsonRequest jsonRequest = new JsonRequest(strMacroProcess, new AnonymousClass3(adUnit, strMacroProcess), 1);
        SigmobRequestQueue sigRequestQueue = Networking.getSigRequestQueue();
        if (sigRequestQueue == null) {
            ad.a("download_start", "0", adUnit, new ad.a() { // from class: com.sigmob.sdk.base.common.i$$ExternalSyntheticLambda2
                @Override // com.sigmob.sdk.base.common.ad.a
                public final void onAddExtra(Object obj) {
                    i.b(strMacroProcess, obj);
                }
            });
            ad.a("download_start", 0, "request queue is null", adUnit, new ad.a() { // from class: com.sigmob.sdk.base.common.i$$ExternalSyntheticLambda3
                @Override // com.sigmob.sdk.base.common.ad.a
                public final void onAddExtra(Object obj) {
                    i.a(strMacroProcess, obj);
                }
            });
        } else {
            jsonRequest.setTag("GDTRequestConvert");
            sigRequestQueue.add(jsonRequest);
        }
    }

    private void a(BaseAdUnit adUnit, boolean isRecord) {
        ClickCommon clickCommon;
        if (adUnit == null || !isRecord || (clickCommon = adUnit.getClickCommon()) == null) {
            return;
        }
        String str = clickCommon.is_final_click ? "1" : "0";
        SigMacroCommon macroCommon = adUnit.getMacroCommon();
        macroCommon.addMarcoKey("_AX_", clickCommon.adarea_x);
        macroCommon.addMarcoKey("_AY_", clickCommon.adarea_y);
        macroCommon.addMarcoKey("_AW_", clickCommon.adarea_w);
        macroCommon.addMarcoKey("_AH_", clickCommon.adarea_h);
        if ("5".equals(clickCommon.sld)) {
            macroCommon.updateClickMarco(SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY);
            macroCommon.addMarcoKey(SigMacroCommon._SLD_, clickCommon.sld);
            macroCommon.addMarcoKey("_TURNX_", clickCommon.turn_x);
            macroCommon.addMarcoKey("_TURNY_", clickCommon.turn_y);
            macroCommon.addMarcoKey("_TURNZ_", clickCommon.turn_z);
            macroCommon.addMarcoKey("_TURNTIME_", clickCommon.turn_time);
            macroCommon.addMarcoKey("_CPTIDS_", String.valueOf(clickCommon.widget_id));
        } else if ("2".equals(clickCommon.sld)) {
            macroCommon.updateClickMarco(SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY);
            macroCommon.addMarcoKey(SigMacroCommon._SLD_, clickCommon.sld);
            macroCommon.addMarcoKey("_CPTIDS_", String.valueOf(clickCommon.widget_id));
            macroCommon.addMarcoKey("_XMAXACC_", clickCommon.x_max_acc);
            macroCommon.addMarcoKey("_YMAXACC_", clickCommon.y_max_acc);
            macroCommon.addMarcoKey("_ZMAXACC_", clickCommon.z_max_acc);
        } else if (adUnit.getCreativeType() != 9) {
            clickCommon.sld = "0";
            macroCommon.updateClickMarco(clickCommon.down, clickCommon.up);
            macroCommon.addMarcoKey(SigMacroCommon._SLD_, "0");
        }
        if (adUnit.getTemplateId() > 0) {
            macroCommon.addMarcoKey(SigMacroCommon._TEMPLATE_, String.valueOf(adUnit.getTemplateId()));
        }
        if (com.sigmob.sdk.base.utils.s.b(clickCommon.click_area)) {
            macroCommon.addMarcoKey(SigMacroCommon._CLICKAREA_, String.valueOf(clickCommon.click_area));
        }
        if (com.sigmob.sdk.base.utils.s.b(clickCommon.click_scene)) {
            macroCommon.addMarcoKey(SigMacroCommon._CLICKSCENE_, String.valueOf(clickCommon.click_scene));
        }
        macroCommon.addMarcoKey(SigMacroCommon._FINALCLICK_, str);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(Object obj) {
        if (obj instanceof PointEntitySigmobError) {
            ((PointEntitySigmobError) obj).setFinal_url(this.o);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(String str, Object obj) {
        if (obj instanceof PointEntitySigmobError) {
            ((PointEntitySigmobError) obj).setFinal_url(str);
        }
    }

    private void b(com.sigmob.sdk.base.a clickUIType, String url, String coordinate, boolean isDeeplink) {
        ah sessionManager;
        String str;
        BaseAdUnit baseAdUnitL = l();
        if (baseAdUnitL == null || (sessionManager = baseAdUnitL.getSessionManager()) == null) {
            return;
        }
        int i = AnonymousClass5.f3183a[clickUIType.ordinal()];
        if (i != 1) {
            str = i != 2 ? "click" : a.t;
        } else {
            str = a.s;
        }
        sessionManager.a(str, 0);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(Object obj) {
        if (obj instanceof PointEntitySigmob) {
            ((PointEntitySigmob) obj).setFinal_url(this.o);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void b(String str, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            ((PointEntitySigmob) obj).setFinal_url(str);
        }
    }

    private BaseAdUnit l() {
        WeakReference<BaseAdUnit> weakReference = this.u;
        if (weakReference == null) {
            return null;
        }
        return weakReference.get();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void m() {
        com.sigmob.sdk.base.views.q qVar = this.r;
        if (qVar == null) {
            return;
        }
        qVar.dismiss();
        this.r.c();
        this.r = null;
        this.m = false;
    }

    public List<com.sigmob.sdk.videoAd.d> a(long currentPosition, long duration) {
        if (duration <= 0 || currentPosition <= 0) {
            return Collections.emptyList();
        }
        ArrayList arrayList = new ArrayList();
        com.sigmob.sdk.videoAd.d dVar = new com.sigmob.sdk.videoAd.d(a.k, currentPosition / duration);
        int size = this.l.size();
        for (int i = 0; i < size; i++) {
            com.sigmob.sdk.videoAd.d dVar2 = this.l.get(i);
            if (dVar2.compareTo(dVar) > 0) {
                break;
            }
            if (!dVar2.isTracked()) {
                arrayList.add(dVar2);
            }
        }
        return arrayList;
    }

    public void a(int duration) {
        this.w = duration;
    }

    public void a(Activity context, BaseAdUnit adUnit, com.sigmob.sdk.base.views.q.b onPrivacyClickListener) {
        if (adUnit == null) {
            return;
        }
        if (context != null) {
            this.s = new WeakReference<>(context);
        }
        this.t = onPrivacyClickListener;
    }

    public void a(Context context, int contentPlayHead, BaseAdUnit adUnit) {
        Preconditions.NoThrow.checkNotNull(context, "context cannot be null.");
        ad.a("start", (String) null, adUnit, (ad.a) null);
        com.sigmob.sdk.base.network.h.a(adUnit, "start");
    }

    public void a(Context context, TouchLocation down, TouchLocation up, com.sigmob.sdk.base.a clickUIType, BaseAdUnit adUnit) {
        Preconditions.NoThrow.checkNotNull(context, "context cannot be null");
    }

    public void a(Context context, BaseAdUnit adUnit) {
        ad.a(PointCategory.LANDING_PAGE_SHOW, (String) null, adUnit, (ad.a) null);
    }

    public void a(Context context, String error, BaseAdUnit adUnit, String cate, int duration) {
        Preconditions.NoThrow.checkNotNull(context, "context cannot be null");
        ad.a(cate, duration, error, adUnit, (ad.a) null);
    }

    public void a(com.sigmob.sdk.base.a clickUIType, String url, String coordinate, boolean isRecord) {
        a(clickUIType, url, coordinate, isRecord, false);
    }

    public void a(com.sigmob.sdk.base.a clickUIType, String url, String coordinate, boolean isRecord, boolean showAppElement) {
        ClickCommon clickCommon;
        BaseAdUnit baseAdUnitL = l();
        if (baseAdUnitL == null || (clickCommon = baseAdUnitL.getClickCommon()) == null) {
            return;
        }
        AndroidMarket androidMarket = baseAdUnitL.getAndroidMarket();
        String str = com.sigmob.sdk.base.utils.s.a((CharSequence) url) ? this.c : url;
        clickCommon.clickUIType = clickUIType;
        clickCommon.clickCoordinate = coordinate;
        clickCommon.clickUrl = str;
        a(baseAdUnitL, isRecord);
        new ao.a().a(an.IGNORE_ABOUT_SCHEME, an.OPEN_WITH_BROWSER, an.MARKET_SCHEME, an.DOWNLOAD_APK, an.FOLLOW_PACKAGE_NAME, an.FOLLOW_DEEP_LINK, an.MINI_PROGRAM).a(new AnonymousClass4(baseAdUnitL, isRecord, androidMarket, showAppElement, clickUIType)).a(l()).a(baseAdUnitL.isSkipSigmobBrowser()).b(baseAdUnitL.getAd().forbiden_parse_landingpage.booleanValue()).a().a(com.sigmob.sdk.b.e(), url);
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r4v0, types: [java.lang.Object, org.json.JSONObject] */
    /* JADX WARN: Type inference failed for: r4v1 */
    /* JADX WARN: Type inference failed for: r4v2, types: [android.content.Context] */
    /* JADX WARN: Type inference failed for: r5v12, types: [java.lang.StringBuilder] */
    public void a(com.sigmob.sdk.base.a clickUIType, String url, String coordinate, boolean isRecord, boolean showAppElement, JSONObject extOp) {
        ?? r4 = extOp;
        SigmobLog.d(f3178a + "handleUrlAction: clickUIType = " + clickUIType + ", url = " + url + ", coordinate = " + coordinate + ", isRecord = " + isRecord + ", showAppElement = " + showAppElement + ", ext = " + r4);
        int iOptInt = r4 == 0 ? 2 : r4.optInt("interaction_type", 2);
        int apkDownloadType = 0;
        boolean zOptBoolean = r4 == 0 ? false : r4.optBoolean("disable_landing", false);
        if (com.sigmob.sdk.base.utils.s.a((CharSequence) url) || !zOptBoolean) {
            a(clickUIType, url, coordinate, isRecord, showAppElement);
            return;
        }
        String strOptString = r4.optString("failback_url");
        String strOptString2 = r4.optString("product_name");
        String strOptString3 = r4.optString("app_icon_url");
        Context contextE = com.sigmob.sdk.b.e();
        try {
            BaseAdUnit baseAdUnitL = l();
            boolean zB = com.sigmob.sdk.base.utils.v.b(baseAdUnitL);
            if (zB) {
                baseAdUnitL.setMraidInteractionType(iOptInt);
            }
            boolean z = zB && baseAdUnitL.enableSmallWindow(Integer.valueOf(iOptInt));
            try {
                if (iOptInt == 1) {
                    com.sigmob.sdk.base.utils.h.a(contextE, Uri.parse(url), (String) null, z);
                } else if (iOptInt == 2) {
                    this.o = url;
                    if (baseAdUnitL != null) {
                        apkDownloadType = baseAdUnitL.getApkDownloadType();
                    }
                    q.a(this.o, strOptString3, strOptString2, apkDownloadType);
                } else if (iOptInt == 7) {
                    com.sigmob.sdk.base.utils.h.a(contextE, r4.optString("wx_app_id"), r4.optString("wx_app_username"), r4.optString("wx_app_path"), r4.optInt("wx_business_type"), r4.optString("wx_ext_msg"));
                } else if (iOptInt == 9) {
                    com.sigmob.sdk.base.utils.h.a(contextE, (Uri) null, r4.optString(com.sigmob.sdk.base.n.p), z);
                }
            } catch (Throwable unused) {
                try {
                    com.sigmob.sdk.base.utils.h.a((Context) r4, Uri.parse(strOptString));
                } catch (Throwable unused2) {
                }
            }
        } catch (Throwable unused3) {
            r4 = contextE;
        }
        ac acVar = this.q;
        if (acVar != null) {
            acVar.onAdClick(isRecord, clickUIType);
        }
    }

    public void a(com.sigmob.sdk.base.a clickUIType, String coordinate, boolean isRecord) {
        a(clickUIType, (String) null, coordinate, isRecord, true);
    }

    public void a(ac onClickListener) {
        this.q = onClickListener;
    }

    public void a(String dspCreativeId) {
        this.i = dspCreativeId;
    }

    public void a(List<com.sigmob.sdk.videoAd.d> fractionalTrackers) {
        Preconditions.NoThrow.checkNotNull(fractionalTrackers, "fractionalTrackers cannot be null");
        this.l.addAll(fractionalTrackers);
        Collections.sort(this.l);
    }

    public boolean a() {
        return this.v;
    }

    public String b() {
        return this.i;
    }

    public void b(Context context, int contentPlayHead, BaseAdUnit adUnit) {
        Preconditions.NoThrow.checkNotNull(context, "context cannot be null");
    }

    public void b(Context context, BaseAdUnit adUnit) {
        ad.a(PointCategory.LANDING_PAGE_CLOSE, (String) null, adUnit, (ad.a) null);
    }

    public void b(BaseAdUnit adUnit) {
        this.u = new WeakReference<>(adUnit);
    }

    public void b(String clickThroughUrl) {
        this.c = clickThroughUrl;
    }

    public String c() {
        return this.c;
    }

    public void c(Context context, int contentPlayHead, BaseAdUnit adUnit) {
        Preconditions.NoThrow.checkNotNull(context, "context cannot be null");
    }

    public void c(BaseAdUnit adUnit) {
        com.sigmob.sdk.base.network.h.a(adUnit, "click");
    }

    public void c(String customCtaText) {
        if (customCtaText == null) {
            return;
        }
        this.f = customCtaText;
    }

    public String d() {
        return this.f;
    }

    public void d(String customSkipText) {
        if (customSkipText == null) {
            return;
        }
        this.g = customSkipText;
    }

    public String e() {
        return this.g;
    }

    public void e(String customCloseIconUrl) {
        if (customCloseIconUrl == null) {
            return;
        }
        this.h = customCloseIconUrl;
    }

    public String f() {
        return this.h;
    }

    public void f(String realClickUrl) {
        BaseAdUnit baseAdUnitL = l();
        if (baseAdUnitL == null) {
            return;
        }
        if (q.a(this.o)) {
            try {
                ak.a(com.sigmob.sdk.b.e(), "正在下载", 1).show();
                return;
            } catch (Throwable unused) {
                return;
            }
        }
        String landing_page = baseAdUnitL.getLanding_page();
        if (com.sigmob.sdk.base.utils.s.b(realClickUrl)) {
            landing_page = realClickUrl;
        }
        String strMacroProcess = baseAdUnitL.getMacroCommon().macroProcess(landing_page);
        if (baseAdUnitL.getsubInteractionType() != 1) {
            this.o = realClickUrl;
            q.a(realClickUrl, baseAdUnitL);
            return;
        }
        JsonRequest jsonRequest = new JsonRequest(strMacroProcess, new AnonymousClass2(baseAdUnitL), 1);
        SigmobRequestQueue sigRequestQueue = Networking.getSigRequestQueue();
        if (sigRequestQueue == null) {
            ad.a("download_start", "0", baseAdUnitL, new ad.a() { // from class: com.sigmob.sdk.base.common.i$$ExternalSyntheticLambda0
                @Override // com.sigmob.sdk.base.common.ad.a
                public final void onAddExtra(Object obj) {
                    this.f$0.b(obj);
                }
            });
            ad.a("download_start", 0, "request queue is null.", baseAdUnitL, new ad.a() { // from class: com.sigmob.sdk.base.common.i$$ExternalSyntheticLambda1
                @Override // com.sigmob.sdk.base.common.ad.a
                public final void onAddExtra(Object obj) {
                    this.f$0.a(obj);
                }
            });
        } else {
            jsonRequest.setTag("GDTRequestConvert");
            sigRequestQueue.add(jsonRequest);
        }
    }

    public Map<String, String> g() {
        return this.b;
    }

    public boolean h() {
        return this.n;
    }

    public boolean i() {
        final BaseAdUnit baseAdUnitL = l();
        if (baseAdUnitL == null) {
            return false;
        }
        SigmobLog.i(f3178a + Constants.SHOW_DOWNLOAD_DIALOG);
        WeakReference<Activity> weakReference = this.s;
        Activity activity = weakReference == null ? null : weakReference.get();
        if (activity != null && baseAdUnitL.getadPrivacy() != null && this.r == null) {
            com.sigmob.sdk.base.views.q qVar = new com.sigmob.sdk.base.views.q(activity, baseAdUnitL);
            this.r = qVar;
            qVar.a(new com.sigmob.sdk.base.views.q.b() { // from class: com.sigmob.sdk.base.common.i.1
                @Override // com.sigmob.sdk.base.views.q.b
                public void a() {
                    SigmobLog.i(i.f3178a + "onCloseClick");
                    i.this.m();
                    ah sessionManager = baseAdUnitL.getSessionManager();
                    if (sessionManager != null) {
                        sessionManager.a(a.g, 0);
                    }
                    if (i.this.t != null) {
                        i.this.t.a();
                    }
                }

                @Override // com.sigmob.sdk.base.views.q.b
                public void a(Error error) {
                    SigmobLog.e(i.f3178a + "onShowFail: error = " + error);
                }

                @Override // com.sigmob.sdk.base.views.q.b
                public void a(String url, String clickCoordinate) {
                    SigmobLog.i(i.f3178a + "onButtonClick");
                    if (i.this.t != null) {
                        i.this.t.a(url, clickCoordinate);
                    }
                    i.this.a(baseAdUnitL.getClickCommon().clickUIType, url, clickCoordinate, true);
                }

                @Override // com.sigmob.sdk.base.views.q.b
                public void b() {
                    SigmobLog.i(i.f3178a + "onShowSuccess");
                    ah sessionManager = baseAdUnitL.getSessionManager();
                    if (sessionManager != null) {
                        sessionManager.a(a.f, 0);
                    }
                    if (i.this.t == null || !i.this.m) {
                        return;
                    }
                    i.this.t.b();
                }
            });
        }
        com.sigmob.sdk.base.views.q qVar2 = this.r;
        if (qVar2 == null || !qVar2.a()) {
            return false;
        }
        if (activity != null && !this.m) {
            boolean zIsFinishing = activity.isFinishing();
            boolean zIsDestroyed = activity.isDestroyed();
            if (!zIsFinishing && !zIsDestroyed) {
                this.r.show();
                this.m = true;
                return true;
            }
            this.m = false;
            this.r.dismiss();
            this.r.c();
            this.r = null;
        }
        return true;
    }

    public boolean j() {
        BaseAdUnit baseAdUnitL = l();
        if (baseAdUnitL == null || !baseAdUnitL.isDownloadDialog()) {
            return false;
        }
        boolean zI = i();
        com.sigmob.sdk.base.utils.k.c(f3178a, "showDownloadDialog: result = " + zI, new Object[0]);
        return zI;
    }

    public void k() {
        this.t = null;
        this.q = null;
        m();
    }
}
