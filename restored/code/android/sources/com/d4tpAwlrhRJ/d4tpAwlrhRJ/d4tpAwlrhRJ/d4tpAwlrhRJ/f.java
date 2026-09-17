package com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ;

import android.app.Activity;
import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import android.text.TextUtils;
import android.util.SparseArray;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import androidx.core.view.PointerIconCompat;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import com.bykv.vk.openvk.api.proto.ValueSet;
import com.bytedance.JProtect;
import com.bytedance.msdk.adapter.gdt.GdtBannerLoader;
import com.bytedance.msdk.adapter.gdt.R;
import com.bytedance.msdk.adapter.gdt.base.config.MediationAdSlotValueSet;
import com.bytedance.msdk.adapter.gdt.base.config.MediationViewBinder;
import com.bytedance.msdk.adapter.gdt.base.proto.AdnAdapterBridgeWrapper;
import com.bytedance.msdk.adapter.gdt.base.proto.AdnAdapterValueSetBuilder;
import com.bytedance.msdk.adapter.gdt.base.proto.MediationBaseAdBridge;
import com.bytedance.msdk.adapter.gdt.base.utils.MediationApiLog;
import com.bytedance.msdk.adapter.gdt.base.utils.MediationValueUtil;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.qq.e.ads.banner2.UnifiedBannerADListener;
import com.qq.e.ads.banner2.UnifiedBannerView;
import com.qq.e.ads.cfg.VideoOption;
import com.qq.e.ads.nativ.ADSize;
import com.qq.e.ads.nativ.MediaView;
import com.qq.e.ads.nativ.NativeADEventListener;
import com.qq.e.ads.nativ.NativeADMediaListener;
import com.qq.e.ads.nativ.NativeADUnifiedListener;
import com.qq.e.ads.nativ.NativeExpressAD;
import com.qq.e.ads.nativ.NativeExpressADView;
import com.qq.e.ads.nativ.NativeExpressMediaListener;
import com.qq.e.ads.nativ.NativeUnifiedAD;
import com.qq.e.ads.nativ.NativeUnifiedADAppMiitInfo;
import com.qq.e.ads.nativ.NativeUnifiedADData;
import com.qq.e.ads.nativ.widget.NativeAdContainer;
import com.qq.e.comm.pi.AdData;
import com.qq.e.comm.util.AdError;
import com.sigmob.sdk.base.mta.PointParamKey;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.concurrent.Callable;
import java.util.concurrent.TimeUnit;
import java.util.function.Function;

/* JADX INFO: loaded from: classes3.dex */
public class f {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private MediationAdSlotValueSet f2446a;
    private Function<SparseArray<Object>, Object> b;
    private FrameLayout.LayoutParams c;
    private final GdtBannerLoader d;
    private boolean e;
    private final NativeExpressAD.NativeExpressADListener f = new NativeExpressAD.NativeExpressADListener() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.2

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        c f2448a;

        @Override // com.qq.e.ads.nativ.NativeExpressAD.NativeExpressADListener
        public void onADClicked(NativeExpressADView nativeExpressADView) {
            c cVar = this.f2448a;
            if (cVar != null) {
                cVar.c();
            }
        }

        @Override // com.qq.e.ads.nativ.NativeExpressAD.NativeExpressADListener
        public void onADClosed(NativeExpressADView nativeExpressADView) {
            c cVar = this.f2448a;
            if (cVar != null) {
                cVar.b();
            }
        }

        @Override // com.qq.e.ads.nativ.NativeExpressAD.NativeExpressADListener
        public void onADExposure(NativeExpressADView nativeExpressADView) {
            c cVar = this.f2448a;
            if (cVar != null) {
                cVar.d();
            }
        }

        @Override // com.qq.e.ads.nativ.NativeExpressAD.NativeExpressADListener
        public void onADLeftApplication(NativeExpressADView nativeExpressADView) {
            c cVar = this.f2448a;
            if (cVar != null) {
                cVar.a();
            }
        }

        @Override // com.qq.e.ads.nativ.NativeExpressAD.NativeExpressADListener
        public void onADLoaded(List<NativeExpressADView> list) {
            if (list == null || list.size() == 0) {
                f.this.d.notifyAdFailed(80001, "load list is null or empty");
                return;
            }
            for (NativeExpressADView nativeExpressADView : list) {
                if (nativeExpressADView != null) {
                    f fVar = f.this;
                    c cVar = fVar.new c(nativeExpressADView, fVar.f2446a, f.this.b);
                    this.f2448a = cVar;
                    cVar.e();
                    return;
                }
            }
        }

        @Override // com.qq.e.ads.NativeAbstractAD.BasicADListener
        public void onNoAD(AdError adError) {
            if (adError != null) {
                f.this.d.notifyAdFailed(adError.getErrorCode(), adError.getErrorMsg());
            } else {
                f.this.d.notifyAdFailed(80001, "error is null");
            }
        }

        @Override // com.qq.e.ads.nativ.NativeExpressAD.NativeExpressADListener
        public void onRenderFail(NativeExpressADView nativeExpressADView) {
            f.this.d.notifyAdFailed(80001, "render fail");
        }

        @Override // com.qq.e.ads.nativ.NativeExpressAD.NativeExpressADListener
        public void onRenderSuccess(NativeExpressADView nativeExpressADView) {
            f.this.d.notifyAdSuccess(this.f2448a, f.this.b);
        }
    };
    private final NativeADUnifiedListener g = new NativeADUnifiedListener() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.3
        @Override // com.qq.e.ads.nativ.NativeADUnifiedListener
        public void onADLoaded(List<NativeUnifiedADData> list) {
            if (list == null || list.size() <= 0) {
                f.this.d.notifyAdFailed(80001, "load list is empty");
                return;
            }
            for (NativeUnifiedADData nativeUnifiedADData : list) {
                if (nativeUnifiedADData != null) {
                    GdtBannerLoader gdtBannerLoader = f.this.d;
                    f fVar = f.this;
                    gdtBannerLoader.notifyAdSuccess(fVar.new b(nativeUnifiedADData, fVar.f2446a, f.this.b), f.this.b);
                    return;
                }
            }
        }

        @Override // com.qq.e.ads.NativeAbstractAD.BasicADListener
        public void onNoAD(AdError adError) {
            if (adError != null) {
                f.this.d.notifyAdFailed(adError.getErrorCode(), adError.getErrorMsg());
            } else {
                f.this.d.notifyAdFailed(80001, "error is null");
            }
        }
    };

    class a extends MediationBaseAdBridge {
        private UnifiedBannerView b;
        private boolean c;
        private boolean d;

        public a(MediationAdSlotValueSet mediationAdSlotValueSet, Function function) {
            super(mediationAdSlotValueSet, function);
            this.c = false;
            this.d = false;
        }

        private void a(Object obj) {
            final int iA = com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.a.a(obj);
            if (iA == -1) {
                return;
            }
            if (f.this.e) {
                n.a(new Runnable() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.a.5
                    @Override // java.lang.Runnable
                    public void run() {
                        a.this.b.sendLossNotification(0, iA, null);
                    }
                });
            } else {
                this.b.sendLossNotification(0, iA, null);
            }
        }

        private View c() {
            return this.b;
        }

        private String d() {
            return f.this.e ? e() : f();
        }

        private String e() {
            try {
                return (String) n.a(new Callable<String>() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.a.6
                    @Override // java.util.concurrent.Callable
                    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
                    public String call() {
                        return a.this.f();
                    }
                }).get(500L, TimeUnit.MILLISECONDS);
            } catch (Throwable th) {
                th.printStackTrace();
                return null;
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public String f() {
            Object obj;
            try {
                UnifiedBannerView unifiedBannerView = this.b;
                if (unifiedBannerView == null || (obj = unifiedBannerView.getExtraInfo().get(PointParamKey.REQUEST_ID)) == null) {
                    return null;
                }
                return obj.toString();
            } catch (Throwable unused) {
                return null;
            }
        }

        public Integer a() {
            UnifiedBannerView unifiedBannerView = this.b;
            return Integer.valueOf((unifiedBannerView == null || !unifiedBannerView.isValid()) ? 4 : 2);
        }

        void a(Context context) {
            if (context instanceof Activity) {
                UnifiedBannerView unifiedBannerView = new UnifiedBannerView((Activity) context, f.this.d.getAdnId(), new UnifiedBannerADListener() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.a.1
                    @Override // com.qq.e.ads.banner2.UnifiedBannerADListener
                    public void onADClicked() {
                        if (a.this.mGMAd != null) {
                            SparseArray<Object> sparseArray = new SparseArray<>();
                            sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_VERTICAL_TEXT));
                            sparseArray.put(-99999985, Void.class);
                            a.this.mGMAd.apply(sparseArray);
                        }
                    }

                    @Override // com.qq.e.ads.banner2.UnifiedBannerADListener
                    public void onADClosed() {
                        if (a.this.mGMAd != null) {
                            SparseArray<Object> sparseArray = new SparseArray<>();
                            sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_HORIZONTAL_DOUBLE_ARROW));
                            sparseArray.put(-99999985, Void.class);
                            a.this.mGMAd.apply(sparseArray);
                        }
                    }

                    @Override // com.qq.e.ads.banner2.UnifiedBannerADListener
                    public void onADExposure() {
                        if (a.this.mGMAd != null) {
                            SparseArray<Object> sparseArray = new SparseArray<>();
                            sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_TEXT));
                            sparseArray.put(-99999985, Void.class);
                            a.this.mGMAd.apply(sparseArray);
                        }
                    }

                    @Override // com.qq.e.ads.banner2.UnifiedBannerADListener
                    public void onADLeftApplication() {
                        if (a.this.mGMAd != null) {
                            SparseArray<Object> sparseArray = new SparseArray<>();
                            sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_TOP_RIGHT_DIAGONAL_DOUBLE_ARROW));
                            sparseArray.put(-99999985, Void.class);
                            a.this.mGMAd.apply(sparseArray);
                        }
                    }

                    @Override // com.qq.e.ads.banner2.UnifiedBannerADListener
                    public void onADReceive() {
                        if (a.this.c) {
                            return;
                        }
                        a.this.c = true;
                        if (a.this.b != null) {
                            if (f.this.d.isClientBidding()) {
                                int ecpm = a.this.b.getECPM();
                                a.this.setCpm(ecpm > 0 ? ecpm : 0.0d);
                            } else if (f.this.d.isMultiBidding()) {
                                a aVar = a.this;
                                aVar.setCpmLevel(aVar.b.getECPMLevel());
                            }
                        }
                        GdtBannerLoader gdtBannerLoader = f.this.d;
                        a aVar2 = a.this;
                        gdtBannerLoader.notifyAdSuccess(aVar2, aVar2.mGMAd);
                    }

                    @Override // com.qq.e.ads.banner2.UnifiedBannerADListener
                    public void onNoAD(AdError adError) {
                        if (a.this.c) {
                            return;
                        }
                        a.this.c = true;
                        f.this.d.notifyAdFailed(adError != null ? adError.getErrorCode() : -1, adError != null ? adError.getErrorMsg() : "位置错误");
                    }
                });
                this.b = unifiedBannerView;
                unifiedBannerView.setRefresh(0);
                this.b.loadAD();
            }
        }

        public void a(Map<String, Object> map) {
            if (f.this.d.isClientBidding() && this.b != null) {
                try {
                    if (f.this.e) {
                        n.a(new Runnable() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.a.4
                            @Override // java.lang.Runnable
                            public void run() {
                                a.this.b.sendWinNotification((int) a.this.getCpm());
                            }
                        });
                    } else {
                        this.b.sendWinNotification((int) getCpm());
                    }
                } catch (Exception unused) {
                }
            }
        }

        @Override // com.bytedance.msdk.adapter.gdt.base.proto.AdnAdapterBaseFunction
        public <T> T applyFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
            if (i == 6081) {
                return (T) c();
            }
            if (i == 8121) {
                return (T) isReadyStatusForProto2(isReadyStatus(), sparseArray, cls);
            }
            if (i == 8120) {
                return (T) Boolean.valueOf(hasDestroyed());
            }
            if (i == 8109) {
                onDestroy();
            } else if (i == 8142) {
                MediationApiLog.i("TMe", "GdtBannerLoader bidWinNotify");
                Map<String, Object> map = (Map) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveCacheThresholdHttpToP2p), Map.class, null);
                if (map != null) {
                    a(map);
                }
            } else if (i == 8144) {
                MediationApiLog.i("TMe", "GdtBannerLoader bidLoseNotify");
                Map<String, Object> map2 = (Map) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveCacheThresholdHttpToP2p), Map.class, null);
                if (map2 != null) {
                    b(map2);
                }
            } else if (i == 8147) {
                return (T) d();
            }
            return (T) MediationValueUtil.checkClassType(cls);
        }

        public Integer b() {
            try {
                Integer num = (Integer) n.a(new Callable<Integer>() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.a.2
                    @Override // java.util.concurrent.Callable
                    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
                    public Integer call() {
                        return a.this.a();
                    }
                }).get(500L, TimeUnit.MILLISECONDS);
                if (num != null) {
                    return num;
                }
                return 4;
            } catch (Exception e) {
                e.printStackTrace();
                return 4;
            }
        }

        public void b(Map<String, Object> map) {
            if (!f.this.d.isClientBidding() || this.b == null || map == null) {
                return;
            }
            try {
                a(map.get(MediationConstant.BIDDING_LOSE_REASON));
            } catch (Exception unused) {
            }
        }

        @Override // com.bykv.vk.openvk.api.proto.Caller
        public <T> T call(int i, ValueSet valueSet, Class<T> cls) {
            return (T) applyFunction(i, AdnAdapterValueSetBuilder.converToSparseArray(valueSet), cls);
        }

        @Override // com.bytedance.msdk.adapter.gdt.base.proto.MediationBaseAdBridge
        public boolean hasDestroyed() {
            return this.d;
        }

        @Override // com.bytedance.msdk.adapter.gdt.base.proto.MediationBaseAdBridge
        public Integer isReadyStatus() {
            return f.this.e ? b() : a();
        }

        @Override // com.bytedance.msdk.adapter.gdt.base.proto.MediationBaseAdBridge
        public void onDestroy() {
            this.d = true;
            new Handler(Looper.getMainLooper()).post(new Runnable() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.a.3
                @Override // java.lang.Runnable
                public void run() {
                    if (a.this.b != null) {
                        a.this.b.destroy();
                    }
                }
            });
        }

        @Override // com.bykv.vk.openvk.api.proto.Bridge
        public ValueSet values() {
            return null;
        }
    }

    class b extends MediationBaseAdBridge {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        NativeUnifiedADData f2457a;
        NativeADMediaListener b;
        private String d;
        private volatile boolean e;

        /* JADX WARN: Code duplicated, block: B:15:0x013e  */
        /* JADX WARN: Code duplicated, block: B:17:0x0147  */
        /* JADX WARN: Code duplicated, block: B:25:0x0166  */
        /* JADX WARN: Code duplicated, block: B:28:0x0175  */
        /* JADX WARN: Code duplicated, block: B:29:0x017a  */
        b(NativeUnifiedADData nativeUnifiedADData, MediationAdSlotValueSet mediationAdSlotValueSet, Function function) {
            Object eCPMLevel;
            int i;
            int i2;
            int i3;
            super(mediationAdSlotValueSet, function);
            this.d = "GdtBanner-gdtNativeAd";
            this.e = false;
            this.b = new NativeADMediaListener() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.b.6
                @Override // com.qq.e.ads.nativ.NativeADMediaListener
                @JProtect
                public void onVideoClicked() {
                    MediationApiLog.i(b.this.d, "onVideoClicked");
                }

                @Override // com.qq.e.ads.nativ.NativeADMediaListener
                @JProtect
                public void onVideoCompleted() {
                }

                @Override // com.qq.e.ads.nativ.NativeADMediaListener
                @JProtect
                public void onVideoError(AdError adError) {
                }

                @Override // com.qq.e.ads.nativ.NativeADMediaListener
                public void onVideoInit() {
                    MediationApiLog.i(b.this.d, "onVideoInit: ");
                }

                @Override // com.qq.e.ads.nativ.NativeADMediaListener
                public void onVideoLoaded(int i4) {
                    MediationApiLog.i(b.this.d, "onVideoLoaded: ");
                }

                @Override // com.qq.e.ads.nativ.NativeADMediaListener
                public void onVideoLoading() {
                    MediationApiLog.i(b.this.d, "onVideoLoading: ");
                }

                @Override // com.qq.e.ads.nativ.NativeADMediaListener
                @JProtect
                public void onVideoPause() {
                }

                @Override // com.qq.e.ads.nativ.NativeADMediaListener
                public void onVideoReady() {
                    MediationApiLog.i(b.this.d, "onVideoReady");
                }

                @Override // com.qq.e.ads.nativ.NativeADMediaListener
                @JProtect
                public void onVideoResume() {
                }

                @Override // com.qq.e.ads.nativ.NativeADMediaListener
                @JProtect
                public void onVideoStart() {
                    MediationApiLog.i(b.this.d, "onVideoStart");
                }

                @Override // com.qq.e.ads.nativ.NativeADMediaListener
                public void onVideoStop() {
                    MediationApiLog.i(b.this.d, "onVideoStop");
                }
            };
            this.f2457a = nativeUnifiedADData;
            SparseArray sparseArray = new SparseArray();
            NativeUnifiedADAppMiitInfo appMiitInfo = this.f2457a.getAppMiitInfo();
            if (appMiitInfo != null) {
                sparseArray.put(8056, appMiitInfo.getAppName());
                sparseArray.put(8057, appMiitInfo.getAuthorName());
                sparseArray.put(8078, Long.valueOf(appMiitInfo.getPackageSizeBytes()));
                sparseArray.put(8047, Integer.valueOf((int) appMiitInfo.getPackageSizeBytes()));
                sparseArray.put(8079, appMiitInfo.getPermissionsUrl());
                sparseArray.put(8080, appMiitInfo.getPrivacyAgreement());
                sparseArray.put(8081, appMiitInfo.getVersionName());
                try {
                    sparseArray.put(8551, appMiitInfo.getDescriptionUrl());
                } catch (Throwable unused) {
                }
            }
            sparseArray.put(8045, this.f2457a.getTitle());
            sparseArray.put(8046, this.f2457a.getDesc());
            sparseArray.put(8061, this.f2457a.getCTAText());
            sparseArray.put(8048, this.f2457a.getIconUrl());
            sparseArray.put(8050, this.f2457a.getImgUrl());
            sparseArray.put(8052, Integer.valueOf(this.f2457a.getPictureWidth()));
            sparseArray.put(8051, Integer.valueOf(this.f2457a.getPictureHeight()));
            sparseArray.put(8053, this.f2457a.getImgList());
            sparseArray.put(8082, Double.valueOf(this.f2457a.getAppScore()));
            sparseArray.put(8049, this.f2457a.getTitle());
            sparseArray.put(8055, Boolean.valueOf(this.f2457a.isAppAd()));
            if (!f.this.d.isClientBidding()) {
                if (f.this.d.isMultiBidding()) {
                    eCPMLevel = this.f2457a.getECPMLevel();
                    i = 8058;
                }
                if (this.f2457a.getAdPatternType() != 2) {
                    i2 = 5;
                } else {
                    if (this.f2457a.getAdPatternType() == 4 && this.f2457a.getAdPatternType() != 1) {
                        if (this.f2457a.getAdPatternType() == 3) {
                            i2 = 4;
                        }
                        if (this.f2457a.isAppAd()) {
                            i3 = 4;
                        } else {
                            i3 = 3;
                        }
                        sparseArray.put(8059, i3);
                        sparseArray.put(8033, false);
                        sparseArray.put(-99999987, 8140);
                        sparseArray.put(-99999985, Void.class);
                        function.apply(sparseArray);
                    }
                    i2 = 3;
                }
                sparseArray.put(8060, i2);
                if (this.f2457a.isAppAd()) {
                    i3 = 4;
                } else {
                    i3 = 3;
                }
                sparseArray.put(8059, i3);
                sparseArray.put(8033, false);
                sparseArray.put(-99999987, 8140);
                sparseArray.put(-99999985, Void.class);
                function.apply(sparseArray);
            }
            eCPMLevel = Double.valueOf(Math.max(this.f2457a.getECPM(), 0.0d));
            i = 8016;
            sparseArray.put(i, eCPMLevel);
            if (this.f2457a.getAdPatternType() != 2) {
                if (this.f2457a.getAdPatternType() == 4) {
                    i2 = 3;
                } else {
                    i2 = 3;
                }
                if (this.f2457a.isAppAd()) {
                    i3 = 4;
                } else {
                    i3 = 3;
                }
                sparseArray.put(8059, i3);
                sparseArray.put(8033, false);
                sparseArray.put(-99999987, 8140);
                sparseArray.put(-99999985, Void.class);
                function.apply(sparseArray);
            }
            i2 = 5;
            sparseArray.put(8060, i2);
            if (this.f2457a.isAppAd()) {
                i3 = 4;
            } else {
                i3 = 3;
            }
            sparseArray.put(8059, i3);
            sparseArray.put(8033, false);
            sparseArray.put(-99999987, 8140);
            sparseArray.put(-99999985, Void.class);
            function.apply(sparseArray);
        }

        /* JADX INFO: Access modifiers changed from: private */
        @JProtect
        public void a(Context context, ViewGroup viewGroup, List<View> list, List<View> list2, List<View> list3, MediationViewBinder mediationViewBinder) {
            NativeAdContainer nativeAdContainer;
            Object tag;
            if (this.f2457a != null) {
                if (list3 != null) {
                    if (list2 == null) {
                        list2 = new ArrayList<>();
                    }
                    list2.addAll(list3);
                }
                List<View> list4 = list2;
                int i = 0;
                if (viewGroup.getChildCount() == 0 || !(viewGroup.getChildAt(0) instanceof NativeAdContainer)) {
                    nativeAdContainer = new NativeAdContainer(context);
                    nativeAdContainer.setTag(R.id.tt_mediation_gdt_developer_view_root_tag_key, MediationConstant.TT_GDT_NATIVE_ROOT_VIEW_TAG);
                    while (viewGroup.getChildCount() > 0) {
                        View childAt = viewGroup.getChildAt(0);
                        childAt.setTag(R.id.tt_mediation_gdt_developer_view_tag_key, MediationConstant.TT_GDT_NATIVE_VIEW_TAG);
                        int iIndexOfChild = viewGroup.indexOfChild(childAt);
                        viewGroup.removeViewInLayout(childAt);
                        if (childAt != null) {
                            nativeAdContainer.addView(childAt, iIndexOfChild, childAt.getLayoutParams());
                        }
                    }
                    viewGroup.removeAllViews();
                    viewGroup.addView(nativeAdContainer, -1, -1);
                } else {
                    nativeAdContainer = (NativeAdContainer) viewGroup.getChildAt(0);
                    while (i < nativeAdContainer.getChildCount()) {
                        View childAt2 = nativeAdContainer.getChildAt(i);
                        if (childAt2 == null || ((tag = childAt2.getTag(R.id.tt_mediation_gdt_developer_view_tag_key)) != null && (tag instanceof String) && ((String) tag).equals(MediationConstant.TT_GDT_NATIVE_VIEW_TAG))) {
                            i++;
                        } else {
                            nativeAdContainer.removeView(childAt2);
                        }
                    }
                }
                NativeAdContainer nativeAdContainer2 = nativeAdContainer;
                ViewGroup viewGroup2 = (ViewGroup) viewGroup.findViewById(mediationViewBinder.mediaViewId);
                this.f2457a.bindAdToView(context, nativeAdContainer2, f.this.c, list, list4);
                if (viewGroup2 != null && this.f2457a.getAdPatternType() == 2) {
                    MediaView mediaView = new MediaView(context);
                    viewGroup2.removeAllViews();
                    viewGroup2.addView(mediaView, -1, -1);
                    VideoOption videoOptionBuild = new VideoOption.Builder().build();
                    if (f.this.f2446a != null && (f.this.f2446a.getGdtVideoOption() instanceof VideoOption)) {
                        videoOptionBuild = (VideoOption) f.this.f2446a.getGdtVideoOption();
                    }
                    this.f2457a.bindMediaView(mediaView, videoOptionBuild, this.b);
                }
                if (!TextUtils.isEmpty(this.f2457a.getCTAText())) {
                    View viewFindViewById = viewGroup.findViewById(mediationViewBinder.callToActionId);
                    ArrayList arrayList = new ArrayList();
                    arrayList.add(viewFindViewById);
                    this.f2457a.bindCTAViews(arrayList);
                }
                this.f2457a.setNativeAdEventListener(new NativeADEventListener() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.b.1
                    @Override // com.qq.e.ads.nativ.NativeADEventListener
                    public void onADClicked() {
                        if (b.this.mGMAd != null) {
                            SparseArray<Object> sparseArray = new SparseArray<>();
                            sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_VERTICAL_TEXT));
                            sparseArray.put(-99999985, Void.class);
                            b.this.mGMAd.apply(sparseArray);
                        }
                    }

                    @Override // com.qq.e.ads.nativ.NativeADEventListener
                    public void onADError(AdError adError) {
                    }

                    @Override // com.qq.e.ads.nativ.NativeADEventListener
                    public void onADExposed() {
                        if (b.this.mGMAd != null) {
                            SparseArray<Object> sparseArray = new SparseArray<>();
                            sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_TEXT));
                            sparseArray.put(-99999985, Void.class);
                            b.this.mGMAd.apply(sparseArray);
                        }
                    }

                    @Override // com.qq.e.ads.nativ.NativeADEventListener
                    public void onADStatusChanged() {
                    }
                });
            }
        }

        private void a(Object obj) {
            final int iA = com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.a.a(obj);
            if (iA == -1) {
                return;
            }
            if (f.this.e) {
                n.a(new Runnable() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.b.5
                    @Override // java.lang.Runnable
                    public void run() {
                        b.this.f2457a.sendLossNotification(0, iA, null);
                    }
                });
            } else {
                this.f2457a.sendLossNotification(0, iA, null);
            }
        }

        private String c() {
            return f.this.e ? d() : e();
        }

        private String d() {
            try {
                return (String) n.a(new Callable<String>() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.b.7
                    @Override // java.util.concurrent.Callable
                    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
                    public String call() {
                        return b.this.e();
                    }
                }).get(500L, TimeUnit.MILLISECONDS);
            } catch (Throwable th) {
                th.printStackTrace();
                return null;
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public String e() {
            Object obj;
            try {
                NativeUnifiedADData nativeUnifiedADData = this.f2457a;
                if (nativeUnifiedADData == null || (obj = nativeUnifiedADData.getExtraInfo().get(PointParamKey.REQUEST_ID)) == null) {
                    return null;
                }
                return obj.toString();
            } catch (Throwable unused) {
                return null;
            }
        }

        public Integer a() {
            NativeUnifiedADData nativeUnifiedADData = this.f2457a;
            return Integer.valueOf((nativeUnifiedADData == null || !nativeUnifiedADData.isValid()) ? 4 : 2);
        }

        public void a(Map<String, Object> map) {
            if (f.this.d.isClientBidding() && this.f2457a != null) {
                try {
                    if (f.this.e) {
                        n.a(new Runnable() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.b.4
                            @Override // java.lang.Runnable
                            public void run() {
                                b.this.f2457a.sendWinNotification((int) b.this.getCpm());
                            }
                        });
                    } else {
                        this.f2457a.sendWinNotification((int) getCpm());
                    }
                } catch (Exception unused) {
                }
            }
        }

        @Override // com.bytedance.msdk.adapter.gdt.base.proto.AdnAdapterBaseFunction
        public <T> T applyFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
            if (i == 8121) {
                return (T) isReadyStatusForProto2(isReadyStatus(), sparseArray, cls);
            }
            if (i == 8120) {
                return (T) Boolean.valueOf(hasDestroyed());
            }
            if (i == 8159) {
                final Activity activity = (Activity) MediationValueUtil.objectValue(sparseArray.get(20033), Activity.class, null);
                final ViewGroup viewGroup = (ViewGroup) MediationValueUtil.objectValue(sparseArray.get(8067), ViewGroup.class, null);
                final List<View> list = (List) MediationValueUtil.objectValue(sparseArray.get(8068), List.class, null);
                final List<View> list2 = (List) MediationValueUtil.objectValue(sparseArray.get(8069), List.class, null);
                final List<View> list3 = (List) MediationValueUtil.objectValue(sparseArray.get(8070), List.class, null);
                final Object objObjectValue = MediationValueUtil.objectValue(sparseArray.get(8071), Object.class, null);
                if (f.this.e) {
                    n.b(new Runnable() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.b.8
                        @Override // java.lang.Runnable
                        public void run() {
                            b.this.a(activity, viewGroup, list, list2, list3, com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.a.a(AdnAdapterBridgeWrapper.covertToFunction(objObjectValue)));
                        }
                    });
                } else {
                    a(activity, viewGroup, list, list2, list3, com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.a.a(AdnAdapterBridgeWrapper.covertToFunction(objObjectValue)));
                }
            } else if (i == 8109) {
                onDestroy();
            } else if (i == 8142) {
                MediationApiLog.i(this.d, "GdtBannerLoader Native bidWinNotify");
                Map<String, Object> map = (Map) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveCacheThresholdHttpToP2p), Map.class, null);
                if (map != null) {
                    a(map);
                }
            } else if (i == 8144) {
                MediationApiLog.i(this.d, "GdtBannerLoader Native bidLoseNotify");
                Map<String, Object> map2 = (Map) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveCacheThresholdHttpToP2p), Map.class, null);
                if (map2 != null) {
                    b(map2);
                }
            } else if (i == 8147) {
                return (T) c();
            }
            return (T) MediationValueUtil.checkClassType(cls);
        }

        public Integer b() {
            try {
                Integer num = (Integer) n.a(new Callable<Integer>() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.b.3
                    @Override // java.util.concurrent.Callable
                    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
                    public Integer call() {
                        return b.this.a();
                    }
                }).get(500L, TimeUnit.MILLISECONDS);
                if (num != null) {
                    return num;
                }
                return 4;
            } catch (Exception e) {
                e.printStackTrace();
                return 4;
            }
        }

        public void b(Map<String, Object> map) {
            if (!f.this.d.isClientBidding() || this.f2457a == null || map == null) {
                return;
            }
            try {
                a(map.get(MediationConstant.BIDDING_LOSE_REASON));
            } catch (Exception unused) {
            }
        }

        @Override // com.bykv.vk.openvk.api.proto.Caller
        public <T> T call(int i, ValueSet valueSet, Class<T> cls) {
            return (T) applyFunction(i, AdnAdapterValueSetBuilder.converToSparseArray(valueSet), cls);
        }

        @Override // com.bytedance.msdk.adapter.gdt.base.proto.MediationBaseAdBridge
        public boolean hasDestroyed() {
            return this.e;
        }

        @Override // com.bytedance.msdk.adapter.gdt.base.proto.MediationBaseAdBridge
        public Integer isReadyStatus() {
            return f.this.e ? b() : a();
        }

        @Override // com.bytedance.msdk.adapter.gdt.base.proto.MediationBaseAdBridge
        public void onDestroy() {
            this.e = true;
            new Handler(Looper.getMainLooper()).post(new Runnable() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.b.2
                @Override // java.lang.Runnable
                public void run() {
                    if (b.this.f2457a != null) {
                        b.this.f2457a.destroy();
                    }
                }
            });
        }

        @Override // com.bykv.vk.openvk.api.proto.Bridge
        public ValueSet values() {
            return null;
        }
    }

    class c extends MediationBaseAdBridge {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        NativeExpressADView f2466a;
        private String c;
        private volatile boolean d;
        private final NativeExpressMediaListener e;

        /* JADX WARN: Code duplicated, block: B:17:0x0096  */
        /* JADX WARN: Code duplicated, block: B:19:0x009d  */
        /* JADX WARN: Code duplicated, block: B:20:0x00a3  */
        /* JADX WARN: Code duplicated, block: B:22:0x00a9  */
        /* JADX WARN: Code duplicated, block: B:24:0x00b3  */
        /* JADX WARN: Code duplicated, block: B:27:? A[RETURN, SYNTHETIC] */
        c(NativeExpressADView nativeExpressADView, MediationAdSlotValueSet mediationAdSlotValueSet, Function function) {
            int i;
            double ecpm;
            super(mediationAdSlotValueSet, function);
            this.c = "GdtBanenrLoader-TTExpressAd";
            this.d = false;
            NativeExpressMediaListener nativeExpressMediaListener = new NativeExpressMediaListener() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.c.6
                @Override // com.qq.e.ads.nativ.NativeExpressMediaListener
                public void onVideoCached(NativeExpressADView nativeExpressADView2) {
                    MediationApiLog.i(c.this.c, "onVideoCached");
                }

                @Override // com.qq.e.ads.nativ.NativeExpressMediaListener
                @JProtect
                public void onVideoComplete(NativeExpressADView nativeExpressADView2) {
                }

                @Override // com.qq.e.ads.nativ.NativeExpressMediaListener
                @JProtect
                public void onVideoError(NativeExpressADView nativeExpressADView2, AdError adError) {
                }

                @Override // com.qq.e.ads.nativ.NativeExpressMediaListener
                public void onVideoInit(NativeExpressADView nativeExpressADView2) {
                    MediationApiLog.i(c.this.c, "onVideoInit: " + c.this.a((AdData.VideoPlayer) nativeExpressADView2.getBoundData().getProperty(AdData.VideoPlayer.class)));
                }

                @Override // com.qq.e.ads.nativ.NativeExpressMediaListener
                public void onVideoLoading(NativeExpressADView nativeExpressADView2) {
                    MediationApiLog.i(c.this.c, "onVideoLoading");
                }

                @Override // com.qq.e.ads.nativ.NativeExpressMediaListener
                public void onVideoPageClose(NativeExpressADView nativeExpressADView2) {
                }

                @Override // com.qq.e.ads.nativ.NativeExpressMediaListener
                public void onVideoPageOpen(NativeExpressADView nativeExpressADView2) {
                }

                @Override // com.qq.e.ads.nativ.NativeExpressMediaListener
                @JProtect
                public void onVideoPause(NativeExpressADView nativeExpressADView2) {
                }

                @Override // com.qq.e.ads.nativ.NativeExpressMediaListener
                public void onVideoReady(NativeExpressADView nativeExpressADView2, long j) {
                }

                @Override // com.qq.e.ads.nativ.NativeExpressMediaListener
                @JProtect
                public void onVideoStart(NativeExpressADView nativeExpressADView2) {
                }
            };
            this.e = nativeExpressMediaListener;
            this.f2466a = nativeExpressADView;
            SparseArray sparseArray = new SparseArray();
            AdData boundData = nativeExpressADView.getBoundData();
            if (boundData.getAdPatternType() != 2) {
                if (boundData.getAdPatternType() == 4 || boundData.getAdPatternType() == 1 || boundData.getAdPatternType() != 3) {
                    sparseArray.put(8060, 3);
                } else {
                    i = 4;
                }
                sparseArray.put(8033, true);
                sparseArray.put(8045, boundData.getTitle());
                sparseArray.put(8046, boundData.getDesc());
                sparseArray.put(8059, 3);
                sparseArray.put(-99999987, 8140);
                sparseArray.put(-99999985, Void.class);
                function.apply(sparseArray);
                if (f.this.d.isClientBidding()) {
                    if (f.this.d.isMultiBidding()) {
                        setCpmLevel(boundData.getECPMLevel());
                    }
                } else {
                    if (boundData.getECPM() != -1) {
                        ecpm = boundData.getECPM();
                    } else {
                        ecpm = 0.0d;
                    }
                    setCpm(ecpm);
                }
            }
            nativeExpressADView.setMediaListener(nativeExpressMediaListener);
            i = 5;
            sparseArray.put(8060, i);
            sparseArray.put(8033, true);
            sparseArray.put(8045, boundData.getTitle());
            sparseArray.put(8046, boundData.getDesc());
            sparseArray.put(8059, 3);
            sparseArray.put(-99999987, 8140);
            sparseArray.put(-99999985, Void.class);
            function.apply(sparseArray);
            if (f.this.d.isClientBidding()) {
                if (f.this.d.isMultiBidding()) {
                    setCpmLevel(boundData.getECPMLevel());
                }
            } else {
                if (boundData.getECPM() != -1) {
                    ecpm = boundData.getECPM();
                } else {
                    ecpm = 0.0d;
                }
                setCpm(ecpm);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public String a(AdData.VideoPlayer videoPlayer) {
            if (videoPlayer == null) {
                return null;
            }
            StringBuilder sb = new StringBuilder("{state:");
            sb.append(videoPlayer.getVideoState()).append(",duration:").append(videoPlayer.getDuration()).append(",position:").append(videoPlayer.getCurrentPosition()).append(com.alipay.sdk.m.y.l.d);
            return sb.toString();
        }

        private void a(Object obj) {
            final int iA = com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.a.a(obj);
            if (iA == -1) {
                return;
            }
            if (f.this.e) {
                n.a(new Runnable() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.c.5
                    @Override // java.lang.Runnable
                    public void run() {
                        c.this.f2466a.sendLossNotification(0, iA, null);
                    }
                });
            } else {
                this.f2466a.sendLossNotification(0, iA, null);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public Integer g() {
            NativeExpressADView nativeExpressADView = this.f2466a;
            return Integer.valueOf((nativeExpressADView == null || !nativeExpressADView.isValid()) ? 4 : 2);
        }

        private Integer h() {
            try {
                Integer num = (Integer) n.a(new Callable<Integer>() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.c.3
                    @Override // java.util.concurrent.Callable
                    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
                    public Integer call() {
                        return c.this.g();
                    }
                }).get(500L, TimeUnit.MILLISECONDS);
                if (num != null) {
                    return num;
                }
                return 4;
            } catch (Exception e) {
                e.printStackTrace();
                return 4;
            }
        }

        private String i() {
            return f.this.e ? j() : k();
        }

        private String j() {
            try {
                return (String) n.a(new Callable<String>() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.c.7
                    @Override // java.util.concurrent.Callable
                    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
                    public String call() {
                        return c.this.k();
                    }
                }).get(500L, TimeUnit.MILLISECONDS);
            } catch (Throwable th) {
                th.printStackTrace();
                return null;
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public String k() {
            Object obj;
            try {
                NativeExpressADView nativeExpressADView = this.f2466a;
                if (nativeExpressADView == null || (obj = nativeExpressADView.getExtraInfo().get(PointParamKey.REQUEST_ID)) == null) {
                    return null;
                }
                return obj.toString();
            } catch (Throwable unused) {
                return null;
            }
        }

        public void a() {
            if (this.mGMAd != null) {
                SparseArray<Object> sparseArray = new SparseArray<>();
                sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_TOP_RIGHT_DIAGONAL_DOUBLE_ARROW));
                sparseArray.put(-99999985, Void.class);
                this.mGMAd.apply(sparseArray);
            }
        }

        public void a(Map<String, Object> map) {
            if (f.this.d.isClientBidding() && this.f2466a != null) {
                try {
                    if (f.this.e) {
                        n.a(new Runnable() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.c.4
                            @Override // java.lang.Runnable
                            public void run() {
                                c.this.f2466a.sendWinNotification((int) c.this.getCpm());
                            }
                        });
                    } else {
                        this.f2466a.sendWinNotification((int) getCpm());
                    }
                } catch (Exception unused) {
                }
            }
        }

        @Override // com.bytedance.msdk.adapter.gdt.base.proto.AdnAdapterBaseFunction
        public <T> T applyFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
            if (i == 6081) {
                return (T) f();
            }
            if (i == 8121) {
                return (T) isReadyStatusForProto2(isReadyStatus(), sparseArray, cls);
            }
            if (i == 8120) {
                return (T) Boolean.valueOf(hasDestroyed());
            }
            if (i == 8109) {
                onDestroy();
            } else if (i == 8142) {
                MediationApiLog.i(this.c, "GdtBannerLoader ExpressNative bidWinNotify");
                Map<String, Object> map = (Map) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveCacheThresholdHttpToP2p), Map.class, null);
                if (map != null) {
                    a(map);
                }
            } else if (i == 8144) {
                MediationApiLog.i(this.c, "GdtBannerLoader ExpressNative bidLoseNotify");
                Map<String, Object> map2 = (Map) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveCacheThresholdHttpToP2p), Map.class, null);
                if (map2 != null) {
                    b(map2);
                }
            } else if (i == 8147) {
                return (T) i();
            }
            return (T) MediationValueUtil.checkClassType(cls);
        }

        public void b() {
            if (this.mGMAd != null) {
                SparseArray<Object> sparseArray = new SparseArray<>();
                sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_HORIZONTAL_DOUBLE_ARROW));
                sparseArray.put(-99999985, Void.class);
                this.mGMAd.apply(sparseArray);
            }
        }

        public void b(Map<String, Object> map) {
            if (!f.this.d.isClientBidding() || this.f2466a == null || map == null) {
                return;
            }
            try {
                a(map.get(MediationConstant.BIDDING_LOSE_REASON));
            } catch (Exception unused) {
            }
        }

        public void c() {
            if (this.mGMAd != null) {
                SparseArray<Object> sparseArray = new SparseArray<>();
                sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_VERTICAL_TEXT));
                sparseArray.put(-99999985, Void.class);
                this.mGMAd.apply(sparseArray);
            }
        }

        @Override // com.bykv.vk.openvk.api.proto.Caller
        public <T> T call(int i, ValueSet valueSet, Class<T> cls) {
            return (T) applyFunction(i, AdnAdapterValueSetBuilder.converToSparseArray(valueSet), cls);
        }

        public void d() {
            if (this.mGMAd != null) {
                SparseArray<Object> sparseArray = new SparseArray<>();
                sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_TEXT));
                sparseArray.put(-99999985, Void.class);
                this.mGMAd.apply(sparseArray);
            }
        }

        @JProtect
        public void e() {
            if (f.this.e) {
                n.b(new Runnable() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.c.1
                    @Override // java.lang.Runnable
                    public void run() {
                        if (c.this.f2466a != null) {
                            c.this.f2466a.render();
                        }
                    }
                });
                return;
            }
            NativeExpressADView nativeExpressADView = this.f2466a;
            if (nativeExpressADView != null) {
                nativeExpressADView.render();
            }
        }

        @JProtect
        public View f() {
            return this.f2466a;
        }

        @Override // com.bytedance.msdk.adapter.gdt.base.proto.MediationBaseAdBridge
        public boolean hasDestroyed() {
            return this.d;
        }

        @Override // com.bytedance.msdk.adapter.gdt.base.proto.MediationBaseAdBridge
        public Integer isReadyStatus() {
            return f.this.e ? h() : g();
        }

        @Override // com.bytedance.msdk.adapter.gdt.base.proto.MediationBaseAdBridge
        public void onDestroy() {
            new Handler(Looper.getMainLooper()).post(new Runnable() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.c.2
                @Override // java.lang.Runnable
                public void run() {
                    if (c.this.f2466a != null) {
                        c.this.f2466a.destroy();
                    }
                }
            });
            this.d = true;
        }

        @Override // com.bykv.vk.openvk.api.proto.Bridge
        public ValueSet values() {
            return null;
        }
    }

    public f(GdtBannerLoader gdtBannerLoader) {
        this.d = gdtBannerLoader;
    }

    private ADSize a(MediationAdSlotValueSet mediationAdSlotValueSet) {
        ADSize aDSize = new ADSize(-1, -2);
        float expressWidth = mediationAdSlotValueSet.getExpressWidth();
        float expressHeight = mediationAdSlotValueSet.getExpressHeight();
        if (expressWidth > 0.0f) {
            return (com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.a.a(mediationAdSlotValueSet) || expressHeight == 0.0f) ? new ADSize((int) expressWidth, -2) : new ADSize((int) expressWidth, (int) expressHeight);
        }
        return aDSize;
    }

    private void a(Context context) {
        NativeExpressAD nativeExpressAD = this.d.isServerBidding() ? new NativeExpressAD(context, a(this.f2446a), this.d.getAdnId(), this.f, this.d.getAdm()) : new NativeExpressAD(context, a(this.f2446a), this.d.getAdnId(), this.f);
        int gdtMaxVideoDuration = this.f2446a.getGdtMaxVideoDuration();
        int gdtMinVideoDuration = this.f2446a.getGdtMinVideoDuration();
        if (gdtMinVideoDuration > 0) {
            nativeExpressAD.setMinVideoDuration(gdtMinVideoDuration);
        }
        if (gdtMaxVideoDuration > 0) {
            nativeExpressAD.setMaxVideoDuration(gdtMaxVideoDuration);
        }
        nativeExpressAD.setVideoOption(this.f2446a.getGdtVideoOption() instanceof VideoOption ? (VideoOption) this.f2446a.getGdtVideoOption() : new VideoOption.Builder().build());
        nativeExpressAD.loadAD(1);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(MediationAdSlotValueSet mediationAdSlotValueSet, Context context) {
        if (mediationAdSlotValueSet.getAdSubType() != 4) {
            new a(mediationAdSlotValueSet, this.b).a(context);
            return;
        }
        int originType = mediationAdSlotValueSet.getOriginType();
        if (originType == 1) {
            a(context.getApplicationContext());
        } else if (originType == 2) {
            b(context.getApplicationContext());
        } else {
            this.d.notifyAdFailed(80001, "originType is mismatch");
        }
    }

    private void b(Context context) {
        NativeUnifiedAD nativeUnifiedAD = this.d.isServerBidding() ? new NativeUnifiedAD(context, this.d.getAdnId(), this.g, this.d.getAdm()) : new NativeUnifiedAD(context, this.d.getAdnId(), this.g);
        int gdtMaxVideoDuration = this.f2446a.getGdtMaxVideoDuration();
        int gdtMinVideoDuration = this.f2446a.getGdtMinVideoDuration();
        if (gdtMinVideoDuration > 0) {
            nativeUnifiedAD.setMinVideoDuration(gdtMinVideoDuration);
        }
        if (gdtMaxVideoDuration > 0) {
            nativeUnifiedAD.setMaxVideoDuration(gdtMaxVideoDuration);
        }
        Object gdtNativeLogoParams = this.f2446a.getGdtNativeLogoParams();
        if (gdtNativeLogoParams instanceof FrameLayout.LayoutParams) {
            this.c = (FrameLayout.LayoutParams) gdtNativeLogoParams;
        }
        nativeUnifiedAD.loadData(1);
    }

    public void a(final Context context, final MediationAdSlotValueSet mediationAdSlotValueSet) {
        if (context == null || mediationAdSlotValueSet == null) {
            this.d.notifyAdFailed(80001, "context is null or adSlotValueSet is null");
            return;
        }
        com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.a.a((Map) mediationAdSlotValueSet.getExtraObject());
        this.f2446a = mediationAdSlotValueSet;
        this.b = this.d.getGMBridge();
        boolean zA = com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.a.a(this.d, mediationAdSlotValueSet);
        this.e = zA;
        if (zA) {
            n.a(new Runnable() { // from class: com.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.d4tpAwlrhRJ.f.1
                @Override // java.lang.Runnable
                public void run() {
                    f.this.a(mediationAdSlotValueSet, context);
                    n.a(getClass().getName(), context);
                }
            });
        } else {
            a(mediationAdSlotValueSet, context);
        }
    }
}
