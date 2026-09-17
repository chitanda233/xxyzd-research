package com.sigmob.sdk.base.network;

import android.content.Context;
import android.util.Base64;
import cn.com.chinatelecom.account.api.utils.Constants;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.models.AdCache;
import com.czhj.sdk.common.models.AdSlot;
import com.czhj.sdk.common.models.App;
import com.czhj.sdk.common.models.BidRequest;
import com.czhj.sdk.common.models.Device;
import com.czhj.sdk.common.models.DeviceId;
import com.czhj.sdk.common.models.HeaderBidding;
import com.czhj.sdk.common.models.ModelBuilderCreator;
import com.czhj.sdk.common.models.Network;
import com.czhj.sdk.common.models.Permission;
import com.czhj.sdk.common.models.Privacy;
import com.czhj.sdk.common.models.User;
import com.czhj.sdk.common.mta.DeviceContext;
import com.czhj.sdk.common.network.SigmobRequest;
import com.czhj.sdk.common.utils.AESUtil;
import com.czhj.sdk.common.utils.AppPackageUtil;
import com.czhj.sdk.common.utils.Preconditions;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.sdk.logger.SigmobLogger;
import com.czhj.volley.DefaultRetryPolicy;
import com.czhj.volley.NetworkResponse;
import com.czhj.volley.ParseError;
import com.czhj.volley.Response;
import com.czhj.volley.VolleyError;
import com.czhj.volley.toolbox.HttpHeaderParser;
import com.czhj.wire.Wire;
import com.kwad.library.solder.lib.ext.PluginError;
import com.sigmob.sdk.Sigmob;
import com.sigmob.sdk.base.common.ab;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.common.n;
import com.sigmob.sdk.base.common.z;
import com.sigmob.sdk.base.i;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.rtb.Ad;
import com.sigmob.sdk.base.models.rtb.AndroidMarket;
import com.sigmob.sdk.base.models.rtb.BidResponse;
import com.sigmob.sdk.base.models.rtb.MaterialMeta;
import com.sigmob.sdk.base.models.rtb.NativeAdSetting;
import com.sigmob.sdk.base.models.rtb.SlotAdSetting;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmobError;
import com.sigmob.sdk.base.o;
import com.sigmob.sdk.base.utils.k;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.sdk.base.utils.v;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.WindAdOptions;
import com.sigmob.windad.WindAds;
import com.sigmob.windad.WindCustomController;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public class a extends SigmobRequest<BidResponse> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3233a = "a";
    private final f.a b;
    private final LoadAdRequest c;
    private byte[] d;

    public a(String url, LoadAdRequest loadAdRequest, f.a listener) {
        super(url, 1, null);
        Preconditions.NoThrow.checkNotNull(listener);
        this.b = listener;
        this.c = loadAdRequest;
        setRetryPolicy(new DefaultRetryPolicy(5000, 0, 0.0f));
        setShouldCache(false);
    }

    /* JADX WARN: Code duplicated, block: B:37:0x0272 A[Catch: all -> 0x03e7, TryCatch #1 {all -> 0x03e7, blocks: (B:3:0x001f, B:5:0x0045, B:6:0x004c, B:8:0x0053, B:12:0x0067, B:14:0x007d, B:72:0x0371, B:74:0x03c0, B:75:0x03cb, B:79:0x03e0, B:15:0x0149, B:17:0x0159, B:19:0x0163, B:20:0x0187, B:22:0x018d, B:25:0x019b, B:38:0x0275, B:40:0x029c, B:41:0x029f, B:43:0x02c5, B:44:0x02c8, B:46:0x02e8, B:47:0x02ea, B:49:0x02f4, B:50:0x02f6, B:52:0x0305, B:53:0x0308, B:55:0x0312, B:56:0x0315, B:58:0x0320, B:59:0x0327, B:61:0x0331, B:62:0x0338, B:64:0x0342, B:65:0x034a, B:67:0x0350, B:71:0x0363, B:32:0x01f1, B:33:0x020c, B:35:0x0268, B:37:0x0272, B:34:0x0210), top: B:87:0x001f }] */
    public static BidRequest.Builder a(LoadAdRequest loadAdRequest) {
        List<Integer> list;
        Integer numValueOf;
        Map<String, AdCache> mapA;
        WindAds.sharedAds().getHandler().post(new Runnable() { // from class: com.sigmob.sdk.base.network.a$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                Sigmob.updateLocationMonitor();
            }
        });
        BidRequest.Builder builder = new BidRequest.Builder();
        DeviceContext deviceContextB = com.sigmob.sdk.b.b();
        Context contextE = com.sigmob.sdk.b.e();
        try {
            App.Builder builderB = b();
            builderB.mraid1_version = ModelBuilderCreator.createVersion(Constants.LOG_UPLOAD_VERSION).build();
            builderB.mraid2_version = ModelBuilderCreator.createVersion("2.2").build();
            Device.Builder builderCreateDevice = ModelBuilderCreator.createDevice(deviceContextB);
            DeviceId.Builder builderCreateDeviceId = ModelBuilderCreator.createDeviceId(deviceContextB);
            if (loadAdRequest != null) {
                builderCreateDeviceId.user_id(loadAdRequest.getUserId());
            }
            int osMarket = AppPackageUtil.getOsMarket(contextE);
            if (osMarket != -1) {
                builderCreateDevice.market_version(Integer.valueOf(osMarket));
            }
            try {
                int hwid = AppPackageUtil.getHWID(contextE);
                if (hwid != -1) {
                    builderCreateDevice.hms_version(Integer.valueOf(hwid));
                }
            } catch (Throwable unused) {
            }
            builderCreateDevice.did(builderCreateDeviceId.build());
            Network.Builder builderCreateNetwork = ModelBuilderCreator.createNetwork(deviceContextB);
            AdSlot.Builder builderCreateAdSlot = ModelBuilderCreator.createAdSlot();
            boolean z = true;
            if (loadAdRequest == null) {
                ArrayList arrayList = new ArrayList();
                arrayList.add(Integer.valueOf(PluginError.ERROR_BUILD_REMOTE_PLUGIN_INFO));
                arrayList.add(6002);
                builderCreateAdSlot.material_type.add(Integer.valueOf(com.sigmob.sdk.base.c.ImageTypeJPEG.a()));
                builderCreateAdSlot.material_type.add(Integer.valueOf(com.sigmob.sdk.base.c.ImageTypePNG.a()));
                builderCreateAdSlot.material_type.add(Integer.valueOf(com.sigmob.sdk.base.c.ImageTypeGIF.a()));
                builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeImage.a()));
                builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeSplashVideo.a()));
                builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeVideo_Tar.a()));
                builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeVideo_Html_Snippet.a()));
                builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeVideo_transparent_html.a()));
                builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeVideo_EndCardURL.a()));
                builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeMRAID.a()));
                builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeMRAIDTWO.a()));
                builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeNewInterstitial.a()));
                builderCreateAdSlot.support_template_id(arrayList);
            } else {
                int adType = loadAdRequest.getAdType();
                builderCreateAdSlot.adslot_type.add(Integer.valueOf(adType));
                if (adType == 5) {
                    String placementId = loadAdRequest.getPlacementId();
                    z zVarA = z.a(placementId);
                    if (zVarA != null) {
                        builderCreateAdSlot.media_request_count(Integer.valueOf(zVarA.f3206a));
                        builderCreateAdSlot.media_ready_count(Integer.valueOf(zVarA.b));
                        builderCreateAdSlot.req_interval_time(Integer.valueOf(zVarA.d));
                        builderCreateAdSlot.pre_req_time(Long.valueOf(zVarA.c));
                    }
                    List<BaseAdUnit> listD = com.sigmob.sdk.base.common.h.d(placementId);
                    if (listD != null) {
                        builderCreateAdSlot.cached_ad_size(Integer.valueOf(listD.size()));
                    }
                }
                if (adType == 2) {
                    builderCreateAdSlot.material_type.add(Integer.valueOf(com.sigmob.sdk.base.c.ImageTypeJPEG.a()));
                    builderCreateAdSlot.material_type.add(Integer.valueOf(com.sigmob.sdk.base.c.ImageTypePNG.a()));
                    builderCreateAdSlot.material_type.add(Integer.valueOf(com.sigmob.sdk.base.c.ImageTypeGIF.a()));
                    builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeImage.a()));
                    builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeSplashVideo.a()));
                } else {
                    if (adType == 1 || adType == 4) {
                        builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeVideo_Tar.a()));
                        builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeVideo_Html_Snippet.a()));
                        builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeVideo_transparent_html.a()));
                        builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeVideo_EndCardURL.a()));
                        builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeMRAID.a()));
                        list = builderCreateAdSlot.creative_type;
                        numValueOf = Integer.valueOf(n.CreativeTypeMRAIDTWO.a());
                    } else if (adType == 6) {
                        builderCreateAdSlot.creative_type.add(Integer.valueOf(n.CreativeTypeMRAIDTWO.a()));
                        list = builderCreateAdSlot.creative_type;
                        numValueOf = Integer.valueOf(n.CreativeTypeNewInterstitial.a());
                    } else {
                        mapA = com.sigmob.sdk.base.common.h.g().a(adType);
                        if (mapA != null) {
                            builderCreateAdSlot.ad_caches(mapA);
                        }
                    }
                    list.add(numValueOf);
                    mapA = com.sigmob.sdk.base.common.h.g().a(adType);
                    if (mapA != null) {
                        builderCreateAdSlot.ad_caches(mapA);
                    }
                }
                ArrayList arrayList2 = new ArrayList();
                arrayList2.add(Integer.valueOf(PluginError.ERROR_BUILD_REMOTE_PLUGIN_INFO));
                arrayList2.add(6002);
                builderCreateAdSlot.support_template_id(arrayList2);
                builderCreateAdSlot.sdk_strategy_index(1);
                String placementId2 = loadAdRequest.getPlacementId();
                if (s.b(placementId2)) {
                    builderCreateAdSlot.adslot_id(placementId2);
                }
                builderCreateAdSlot.latest_crid(loadAdRequest.getLastCrid());
                builderCreateAdSlot.latest_camp_id(loadAdRequest.getLastCampid());
                builderCreateAdSlot.ad_count(Integer.valueOf(loadAdRequest.getAdCount()));
                builderCreateAdSlot.bidfloor(loadAdRequest.getBidFloor());
                Map<String, String> options = loadAdRequest.getOptions();
                if (options != null) {
                    builder.options(options);
                }
                builder.request_scene_type = Integer.valueOf(loadAdRequest.getRequest_scene_type());
                builder.ad_is_expired = Boolean.valueOf(com.sigmob.sdk.manager.b.a(builder.request_scene_type));
                String originVid = loadAdRequest.getOriginVid();
                if (s.b(originVid)) {
                    builder.origin_vid = originVid;
                }
                String originPrice = loadAdRequest.getOriginPrice();
                if (s.b(originPrice)) {
                    builder.origin_price = originPrice;
                }
                HeaderBidding.Builder builder2 = new HeaderBidding.Builder();
                String bidToken = loadAdRequest.getBidToken();
                if (s.b(bidToken)) {
                    builder2.bid_token(bidToken);
                }
                String currency = loadAdRequest.getCurrency();
                if (s.b(currency)) {
                    builder2.cur(currency);
                }
                builder.header_bidding(builder2.build());
                if (builder.ext_options == null) {
                    builder.ext_options = new HashMap();
                }
                String loadId = loadAdRequest.getLoadId();
                if (s.b(loadId)) {
                    builder.ext_options.put("load_id", loadId);
                }
                Map<?, ?> tBAdxInfo = loadAdRequest.getTBAdxInfo();
                if (com.sigmob.sdk.base.utils.f.b(tBAdxInfo)) {
                    for (Map.Entry<?, ?> entry : tBAdxInfo.entrySet()) {
                        Object key = entry.getKey();
                        Object value = entry.getValue();
                        if (key != null && value != null) {
                            builder.ext_options.put(key.toString(), value.toString());
                        }
                    }
                }
            }
            builder.device(ModelBuilderCreator.createDevice(deviceContextB).build());
            builder.slots.add(builderCreateAdSlot.build());
            builder.user(c().build());
            builder.privacy(d().build());
            builder.app(builderB.build());
            builder.device(builderCreateDevice.build());
            builder.network(builderCreateNetwork.build());
            builder.req_timestamp = Long.valueOf(System.currentTimeMillis());
            if (s.b("4.25.14")) {
                builder.sdk_version(ModelBuilderCreator.createVersion("4.25.14").build());
            }
            builder.disable_mediation = true;
            builder.wx_program_req(ModelBuilderCreator.createWXProgramReq());
            if (com.sigmob.sdk.base.common.f.c()) {
                z = false;
            }
            builder.disable_install_package = Boolean.valueOf(z);
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
        }
        return builder;
    }

    private void a(final int adType, final String placementId, final String requestId, int errorCode, String message) {
        ad.a(PointCategory.SERVER_ERROR, errorCode, message, (BaseAdUnit) null, new ad.a() { // from class: com.sigmob.sdk.base.network.a$$ExternalSyntheticLambda1
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                a.a(requestId, placementId, adType, obj);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(String str, String str2, int i, Object obj) {
        if (obj instanceof PointEntitySigmobError) {
            PointEntitySigmobError pointEntitySigmobError = (PointEntitySigmobError) obj;
            pointEntitySigmobError.setRequest_id(str);
            pointEntitySigmobError.setPlacement_id(str2);
            pointEntitySigmobError.setAdtype(String.valueOf(i));
        }
    }

    public static App.Builder b() {
        App.Builder builderCreateApp = ModelBuilderCreator.createApp();
        builderCreateApp.sdk_ext_cap.add(4);
        builderCreateApp.app_id(WindAds.sharedAds().getAppId());
        Permission.Builder builder = new Permission.Builder();
        boolean zJ = o.a().j();
        boolean sensorStatus = WindAds.sharedAds().getSensorStatus();
        boolean zF = (!sensorStatus || zJ) ? false : com.sigmob.sdk.b.f();
        boolean z = sensorStatus && zF;
        SigmobLogger.d(f3233a, "createApp: accelerometer = " + z + ", complianceMark = " + zJ + ", sensorStatus = " + sensorStatus + ", sensorEnable = " + zF, new Object[0]);
        builder.accelerometer(Boolean.valueOf(z));
        builderCreateApp.permission(builder.build());
        return builderCreateApp;
    }

    public static User.Builder c() {
        User.Builder builder = new User.Builder();
        builder.is_minor = Boolean.valueOf(!i.a().d());
        builder.disable_personalized_recommendation = Boolean.valueOf(!i.a().e());
        builder.change_recommendation_state = Boolean.valueOf(i.a().f());
        return builder;
    }

    public static Privacy.Builder d() {
        int iG;
        Privacy.Builder builder = new Privacy.Builder();
        builder.age(Integer.valueOf(i.a().b()));
        builder.child_protection(Integer.valueOf(i.a().c()));
        try {
            iG = i.a().g();
        } catch (Throwable unused) {
            iG = 0;
        }
        builder.gdpr_consent(Integer.valueOf(iG));
        WindAdOptions options = WindAds.sharedAds().getOptions();
        WindCustomController windCustomController = (options == null || options.getCustomController() == null) ? new WindCustomController() : options.getCustomController();
        builder.allow_geo = Boolean.valueOf(windCustomController.isCanUseLocation());
        builder.allow_imei = Boolean.valueOf(windCustomController.isCanUsePhoneState());
        builder.allow_oaid = Boolean.valueOf(windCustomController.isCanUseOaid());
        builder.allow_android_id = Boolean.valueOf(windCustomController.isCanUseAndroidId());
        builder.allow_installed_apps = Boolean.valueOf(windCustomController.isCanUseAppList());
        builder.allow_carrier_code = Boolean.valueOf(windCustomController.isCanUseSimOperator());
        builder.allow_space_size = Boolean.valueOf(windCustomController.isCanUseSpaceSize());
        return builder;
    }

    public f.a a() {
        return this.b;
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // com.czhj.volley.Request
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void deliverResponse(BidResponse bidResponse) {
        String strDecryptString;
        z zVarA;
        NativeAdSetting nativeAdSetting;
        z zVarA2;
        int adType = this.c.getAdType();
        String placementId = this.c.getPlacementId();
        AndroidMarket androidMarket = null;
        int i = 5;
        if (bidResponse != null) {
            int i2 = 0;
            if (adType == 5) {
                z zVarA3 = z.a(placementId);
                if (zVarA3 != null) {
                    zVarA3.c = System.currentTimeMillis();
                    zVarA3.g = zVarA3.c;
                    zVarA3.b = 0;
                    zVarA3.f3206a = 0;
                    SlotAdSetting slotAdSetting = bidResponse.slot_ad_setting;
                    if (slotAdSetting != null && (nativeAdSetting = slotAdSetting.native_setting) != null) {
                        zVarA3.e = ((Integer) Wire.get(nativeAdSetting.ad_pool_size, 0)).intValue();
                        zVarA3.d = ((Integer) Wire.get(nativeAdSetting.req_interval_time, 0)).intValue();
                        zVarA3.f = ((Integer) Wire.get(nativeAdSetting.media_expected_floor, 0)).intValue();
                        ab.a().a(((Integer) Wire.get(nativeAdSetting.log_interval_time, 0)).intValue());
                    }
                }
                z.a(placementId, zVarA3);
            }
            List<Ad> list = bidResponse.ads;
            int size = list.size();
            if (com.sigmob.sdk.base.utils.f.b(list)) {
                o.f3242a = Boolean.valueOf(v.a(bidResponse.noncompliance_mark));
            }
            k.c(f3233a, "noncomplianceMark(bid) = " + o.f3242a + ", size = " + size, new Object[0]);
            String str = bidResponse.uid;
            if (s.b(str)) {
                try {
                    strDecryptString = AESUtil.DecryptStringServer(str, "KGpfzbYsn4T9Jyuq");
                } catch (NoSuchMethodError unused) {
                    strDecryptString = AESUtil.DecryptString(str, "KGpfzbYsn4T9Jyuq");
                }
                ClientMetadata.getInstance().setUid(strDecryptString);
            }
            if (s.b(bidResponse.adx_id)) {
                this.c.setAdx_id(bidResponse.adx_id);
            }
            this.c.setRequestId(bidResponse.request_id);
            if (com.sigmob.sdk.base.utils.f.a(list)) {
                Long l = bidResponse.error_code;
                int errorCode = l == null ? WindAdError.ERROR_AD_ERROR.getErrorCode() : l.intValue();
                a(adType, placementId, bidResponse.request_id, errorCode, bidResponse.error_message);
                f.a(this.b, errorCode, bidResponse.error_message, bidResponse.request_id, this.c);
                return;
            }
            try {
                ArrayList arrayList = new ArrayList();
                while (i2 < size) {
                    Ad ad = list.get(i2);
                    if (this.c.getAdType() == 6 && com.sigmob.sdk.base.utils.f.b(ad.materials) && v.b(bidResponse.slot_ad_setting) && v.b(bidResponse.slot_ad_setting.interstitial_setting)) {
                        for (MaterialMeta materialMeta : ad.materials) {
                            if (materialMeta != null && materialMeta.android_market != null && materialMeta.android_market.type != null) {
                                Boolean bool = bidResponse.slot_ad_setting.interstitial_setting.click_close_ad;
                                Integer num = bidResponse.slot_ad_setting.interstitial_setting.seconds_close_ad;
                                if (materialMeta.android_market.type.intValue() == 1 && (v.a(bool) || v.a((Number) num))) {
                                    materialMeta.android_market = androidMarket;
                                }
                            }
                        }
                    }
                    BaseAdUnit baseAdUnitAdUnit = BaseAdUnit.adUnit(ad, bidResponse.request_id, this.c, bidResponse.slot_ad_setting, bidResponse.scene, bidResponse.uid, bidResponse.expiration_time, bidResponse.bidding_response);
                    baseAdUnitAdUnit.setAd_type(adType);
                    baseAdUnitAdUnit.setAdx_id(this.c.getAdx_id());
                    baseAdUnitAdUnit.setAdslot_id(placementId);
                    baseAdUnitAdUnit.setHalfInterstitial(this.c.isHalfInterstitial());
                    baseAdUnitAdUnit.setRvCallBackUrl(bidResponse.rv_callback_url);
                    baseAdUnitAdUnit.setTraceId(this.c.getTraceId());
                    baseAdUnitAdUnit.setOriginVid(this.c.getOriginVid());
                    baseAdUnitAdUnit.setBid_token(this.c.getBidToken());
                    baseAdUnitAdUnit.setRequestSceneType(this.c.getRequest_scene_type());
                    Map<String, String> map = bidResponse.saas_options;
                    try {
                        if (com.sigmob.sdk.base.utils.f.b(map) && map.containsKey("adInfoList")) {
                            List list2 = (List) com.sigmob.sdk.base.utils.i.a(map.get("adInfoList"), (Class<?>) List.class, Map.class);
                            if (com.sigmob.sdk.base.utils.f.b(list2) && com.sigmob.sdk.base.utils.f.a(i2, list2)) {
                                Map map2 = (Map) list2.get(i2);
                                ArrayList arrayList2 = new ArrayList();
                                arrayList2.add(map2);
                                String strA = com.sigmob.sdk.base.utils.i.a(arrayList2);
                                HashMap map3 = new HashMap();
                                map3.put("adInfoList", strA);
                                baseAdUnitAdUnit.setSaasOptions(map3);
                            }
                        }
                    } catch (Exception unused2) {
                    }
                    arrayList.add(baseAdUnitAdUnit);
                    i2++;
                    androidMarket = null;
                    i = 5;
                }
                if (adType == i && (zVarA = z.a(placementId)) != null) {
                    com.sigmob.sdk.base.common.h.a(placementId, arrayList, zVarA.e);
                }
                f.a(this.b, arrayList, this.c);
                if (adType == 6 || adType == 1 || adType == 4) {
                    com.sigmob.sdk.base.common.h.a(bidResponse.request_id, bidResponse);
                    return;
                }
                return;
            } catch (Throwable th) {
                SigmobLog.e("ads Response: error ", th);
            }
        } else if (adType == 5 && (zVarA2 = z.a(placementId)) != null) {
            zVarA2.g = zVarA2.c;
        }
        f.a(this.b, WindAdError.ERROR_SIGMOB_INFORMATION_LOSE.getErrorCode(), "bidResponse is null", null, this.c);
    }

    @Override // com.czhj.volley.Request
    public void deliverError(VolleyError error) {
        f.a aVar;
        WindAdError windAdError;
        z zVarA;
        String placementId = this.c.getPlacementId();
        if (this.c.getAdType() == 5 && (zVarA = z.a(placementId)) != null) {
            zVarA.g = zVarA.c;
        }
        if (error instanceof ParseError) {
            aVar = this.b;
            windAdError = WindAdError.ERROR_SIGMOB_INFORMATION_LOSE;
        } else {
            SigmobLog.e(placementId + " ERROR_SIGMOB_NETWORK " + error.getMessage());
            aVar = this.b;
            windAdError = WindAdError.ERROR_SIGMOB_NETWORK;
        }
        f.a(aVar, windAdError.getErrorCode(), error.getMessage(), null, this.c);
    }

    @Override // com.czhj.sdk.common.network.SigmobRequest, com.czhj.volley.Request
    public byte[] getBody() {
        return this.d;
    }

    @Override // com.czhj.sdk.common.network.SigmobRequest, com.czhj.volley.Request
    public String getBodyContentType() {
        return "application/octet-stream";
    }

    @Override // com.czhj.sdk.common.network.SigmobRequest, com.czhj.volley.Request
    public Map<String, String> getHeaders() {
        BidRequest bidRequestBuild;
        Map<String, String> headers = super.getHeaders();
        try {
            headers.put("agn", Base64.encodeToString(AESUtil.generateNonce(), 2));
        } catch (NoSuchMethodError unused) {
            headers.put("e", "1");
        }
        try {
            LoadAdRequest loadAdRequest = this.c;
            bidRequestBuild = loadAdRequest != null ? a(loadAdRequest).build() : null;
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
        }
        if (bidRequestBuild == null) {
            SigmobLog.e("builder Ads Post entry fail ");
            return null;
        }
        try {
            byte[] bArrEncode = bidRequestBuild.encode();
            this.d = bArrEncode;
            this.d = c.b(bArrEncode);
            headers.put(com.alipay.sdk.m.m.b.m, "1");
        } catch (Throwable unused2) {
            headers.remove(com.alipay.sdk.m.m.b.m);
            this.d = bidRequestBuild.encode();
        }
        try {
            this.d = AESUtil.Encrypt(this.d, "KGpfzbYsn4T9Jyuq");
        } catch (Exception e) {
            e.printStackTrace();
            headers.remove("e");
            headers.remove("agn");
        }
        return headers;
    }

    @Override // com.czhj.sdk.common.network.SigmobRequest, com.czhj.volley.Request
    protected Response<BidResponse> parseNetworkResponse(final NetworkResponse networkResponse) {
        try {
            if (networkResponse.data == null) {
                return Response.error(new ParseError(networkResponse));
            }
            BidResponse bidResponseDecode = BidResponse.ADAPTER.decode((networkResponse.headers.containsKey(com.alipay.sdk.m.m.b.m) && "1".equals(networkResponse.headers.get(com.alipay.sdk.m.m.b.m))) ? c.a(networkResponse.data) : networkResponse.data);
            return bidResponseDecode == null ? Response.error(new ParseError(networkResponse)) : Response.success(bidResponseDecode, HttpHeaderParser.parseCacheHeaders(networkResponse));
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
            return Response.error(new ParseError(th));
        }
    }
}
