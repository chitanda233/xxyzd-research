package com.h7brb.h7brb.h7brb.h7brb.h7brb;

import android.app.Activity;
import android.content.Context;
import android.content.DialogInterface;
import android.text.TextUtils;
import android.util.SparseArray;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import androidx.core.view.PointerIconCompat;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import com.bykv.vk.openvk.api.proto.ValueSet;
import com.bytedance.JProtect;
import com.bytedance.msdk.adapter.ks.KsBannerLoader;
import com.bytedance.msdk.adapter.ks.base.config.MediationAdSlotValueSet;
import com.bytedance.msdk.adapter.ks.base.config.MediationViewBinder;
import com.bytedance.msdk.adapter.ks.base.proto.AdnAdapterBridgeWrapper;
import com.bytedance.msdk.adapter.ks.base.proto.AdnAdapterValueSetBuilder;
import com.bytedance.msdk.adapter.ks.base.proto.MediationBaseAdBridge;
import com.bytedance.msdk.adapter.ks.base.utils.MediationApiLog;
import com.bytedance.msdk.adapter.ks.base.utils.MediationValueUtil;
import com.kwad.components.core.internal.api.KSAdVideoPlayConfigImpl;
import com.kwad.sdk.api.KsAdSDK;
import com.kwad.sdk.api.KsBannerAd;
import com.kwad.sdk.api.KsFeedAd;
import com.kwad.sdk.api.KsImage;
import com.kwad.sdk.api.KsLoadManager;
import com.kwad.sdk.api.KsNativeAd;
import com.kwad.sdk.api.KsScene;
import com.kwad.sdk.api.model.AdExposureFailedReason;
import java.lang.ref.WeakReference;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.concurrent.Callable;
import java.util.concurrent.TimeUnit;
import java.util.function.Function;

/* JADX INFO: loaded from: classes3.dex */
public class g {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private MediationAdSlotValueSet f2554a;
    private Function<SparseArray<Object>, Object> b;
    private final KsBannerLoader c;
    private boolean d;
    private WeakReference<Context> e;

    class a extends MediationBaseAdBridge {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        KsBannerAd f2559a;
        View b;
        KSAdVideoPlayConfigImpl c;

        public a(KsBannerAd ksBannerAd, MediationAdSlotValueSet mediationAdSlotValueSet, Function<SparseArray<Object>, Object> function) {
            super(mediationAdSlotValueSet, function);
            this.f2559a = ksBannerAd;
            if (g.this.c.isClientBidding()) {
                int ecpm = ksBannerAd.getECPM();
                setCpm(ecpm > 0 ? ecpm : 0.0d);
            }
            b();
        }

        private void b() {
            Context context = (Context) g.this.e.get();
            if (context != null) {
                if (g.this.f2554a != null) {
                    KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl = new KSAdVideoPlayConfigImpl();
                    this.c = kSAdVideoPlayConfigImpl;
                    kSAdVideoPlayConfigImpl.setVideoSoundEnable(!g.this.f2554a.isMuted());
                }
                this.b = this.f2559a.getView(context, new KsBannerAd.BannerAdInteractionListener() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.a.1
                    @Override // com.kwad.sdk.api.KsBannerAd.BannerAdInteractionListener
                    public void onAdClicked() {
                        if (a.this.mGMAd != null) {
                            SparseArray<Object> sparseArray = new SparseArray<>();
                            sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_VERTICAL_TEXT));
                            sparseArray.put(-99999985, Void.class);
                            a.this.mGMAd.apply(sparseArray);
                        }
                    }

                    @Override // com.kwad.sdk.api.KsBannerAd.BannerAdInteractionListener
                    public void onAdClose() {
                        if (a.this.mGMAd != null) {
                            SparseArray<Object> sparseArray = new SparseArray<>();
                            sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_HORIZONTAL_DOUBLE_ARROW));
                            sparseArray.put(-99999985, Void.class);
                            a.this.mGMAd.apply(sparseArray);
                        }
                    }

                    @Override // com.kwad.sdk.api.KsBannerAd.BannerAdInteractionListener
                    public void onAdShow() {
                        if (a.this.mGMAd != null) {
                            SparseArray<Object> sparseArray = new SparseArray<>();
                            sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_TEXT));
                            sparseArray.put(-99999985, Void.class);
                            a.this.mGMAd.apply(sparseArray);
                        }
                    }

                    @Override // com.kwad.sdk.api.KsBannerAd.BannerAdInteractionListener
                    public void onAdShowError(int i, String str) {
                        MediationApiLog.i("ksBanner", "onAdShowError code: " + i + " msg: " + str);
                    }
                }, this.c);
            }
        }

        private String c() {
            return g.this.d ? d() : e();
        }

        private String d() {
            try {
                return (String) o.a(new Callable<String>() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.a.2
                    @Override // java.util.concurrent.Callable
                    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
                    public String call() {
                        return a.this.e();
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
                KsBannerAd ksBannerAd = this.f2559a;
                if (ksBannerAd == null || (obj = ksBannerAd.getMediaExtraInfo().get("llsid")) == null) {
                    return null;
                }
                return obj.toString();
            } catch (Throwable unused) {
                return null;
            }
        }

        @JProtect
        public View a() {
            return this.b;
        }

        @Override // com.bytedance.msdk.adapter.ks.base.proto.AdnAdapterBaseFunction
        public <T> T applyFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
            if (i == 6081) {
                return (T) a();
            }
            if (i == 8121) {
                return (T) isReadyStatusForProto2(isReadyStatus(), sparseArray, cls);
            }
            if (i == 8120) {
                return (T) Boolean.valueOf(hasDestroyed());
            }
            if (i == 8109) {
                onDestroy();
            } else {
                if (i == 8147) {
                    return (T) c();
                }
                if (i == 8142) {
                    if (p.a(this.f2559a)) {
                        Map map = (Map) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveCacheThresholdHttpToP2p), Map.class, null);
                        MediationApiLog.i("ksBanner -------ks_bid_win --------- map = " + map);
                        if (map != null) {
                            long jA = p.a((Map<String, Object>) map);
                            long jB = p.b((Map<String, Object>) map);
                            MediationApiLog.i("ksBanner -------ks_bid_win --------- bidEcpm = " + jA + " loseBidEcpm = " + jB);
                            KsBannerAd ksBannerAd = this.f2559a;
                            if (ksBannerAd != null) {
                                ksBannerAd.setBidEcpm(jA, jB);
                            }
                        }
                    }
                } else if (i == 8144 && p.b(this.f2559a)) {
                    Map map2 = (Map) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveCacheThresholdHttpToP2p), Map.class, null);
                    MediationApiLog.i("ksBanner -------ks_bid_lose --------- map = " + map2);
                    if (map2 != null) {
                        int iC = p.c(map2);
                        int iD = p.d(map2);
                        int iE = p.e(map2);
                        String strF = p.f(map2);
                        MediationApiLog.i("ksBanner -------ks_bid_lose --------- bidEcpm = " + iD + " failureCode = " + iC + "adnType = " + iE + " adnName = " + strF);
                        if (this.f2559a != null) {
                            AdExposureFailedReason adExposureFailedReason = new AdExposureFailedReason();
                            adExposureFailedReason.setWinEcpm(iD);
                            adExposureFailedReason.setAdnType(iE);
                            adExposureFailedReason.setAdnName(strF);
                            this.f2559a.reportAdExposureFailed(iC, adExposureFailedReason);
                        }
                    }
                }
            }
            return (T) MediationValueUtil.checkClassType(cls);
        }

        @Override // com.bykv.vk.openvk.api.proto.Caller
        public <T> T call(int i, ValueSet valueSet, Class<T> cls) {
            return (T) applyFunction(i, AdnAdapterValueSetBuilder.converToSparseArray(valueSet), cls);
        }

        @Override // com.bytedance.msdk.adapter.ks.base.proto.MediationBaseAdBridge
        public boolean hasDestroyed() {
            return this.f2559a == null;
        }

        @Override // com.bytedance.msdk.adapter.ks.base.proto.MediationBaseAdBridge
        public void onDestroy() {
            if (this.f2559a != null) {
                this.f2559a = null;
            }
        }

        @Override // com.bykv.vk.openvk.api.proto.Bridge
        public ValueSet values() {
            return null;
        }
    }

    class b extends MediationBaseAdBridge {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        KsFeedAd f2562a;
        View b;

        public b(KsFeedAd ksFeedAd, MediationAdSlotValueSet mediationAdSlotValueSet, Function function) {
            super(mediationAdSlotValueSet, function);
            this.f2562a = ksFeedAd;
            if (g.this.c.isClientBidding()) {
                int ecpm = ksFeedAd.getECPM();
                setCpm(ecpm > 0 ? ecpm : 0.0d);
            }
            this.f2562a.setAdInteractionListener(new KsFeedAd.AdInteractionListener() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.b.1
                @Override // com.kwad.sdk.api.KsFeedAd.AdInteractionListener
                public void onAdClicked() {
                    if (b.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_VERTICAL_TEXT));
                        sparseArray.put(-99999985, Void.class);
                        b.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.kwad.sdk.api.KsFeedAd.AdInteractionListener
                public void onAdShow() {
                    if (b.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_TEXT));
                        sparseArray.put(-99999985, Void.class);
                        b.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.kwad.sdk.api.KsFeedAd.AdInteractionListener
                public void onDislikeClicked() {
                    if (b.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_HORIZONTAL_DOUBLE_ARROW));
                        sparseArray.put(-99999985, Void.class);
                        b.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.kwad.sdk.api.KsFeedAd.AdInteractionListener
                public void onDownloadTipsDialogDismiss() {
                }

                @Override // com.kwad.sdk.api.KsFeedAd.AdInteractionListener
                public void onDownloadTipsDialogShow() {
                }
            });
            if (g.this.f2554a != null) {
                KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl = new KSAdVideoPlayConfigImpl();
                kSAdVideoPlayConfigImpl.setVideoSoundEnable(!g.this.f2554a.isMuted());
                ksFeedAd.setVideoPlayConfig(kSAdVideoPlayConfigImpl);
            }
            SparseArray<Object> sparseArray = new SparseArray<>();
            sparseArray.put(-99999987, 8140);
            sparseArray.put(-99999985, Void.class);
            sparseArray.put(8033, true);
            sparseArray.put(8059, Integer.valueOf(p.a(this.f2562a.getInteractionType())));
            this.mGMAd.apply(sparseArray);
        }

        private void c() {
            o.b(new Runnable() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.b.2
                @Override // java.lang.Runnable
                public void run() {
                    b.this.d();
                }
            });
        }

        /* JADX INFO: Access modifiers changed from: private */
        public void d() {
            try {
                KsFeedAd ksFeedAd = this.f2562a;
                if (ksFeedAd != null) {
                    ksFeedAd.render(new KsFeedAd.AdRenderListener() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.b.3
                        @Override // com.kwad.sdk.api.KsFeedAd.AdRenderListener
                        public void onAdRenderFailed(int i, String str) {
                            g.this.c.notifyAdFailed(i, str);
                        }

                        @Override // com.kwad.sdk.api.KsFeedAd.AdRenderListener
                        public void onAdRenderSuccess(View view) {
                            Context context = (Context) g.this.e.get();
                            if (context == null && view != null) {
                                context = view.getContext();
                            }
                            if (b.this.f2562a != null && context != null) {
                                b bVar = b.this;
                                bVar.b = bVar.f2562a.getFeedView(context);
                            }
                            KsBannerLoader ksBannerLoader = g.this.c;
                            b bVar2 = b.this;
                            ksBannerLoader.notifyAdSuccess(bVar2, bVar2.mGMAd);
                        }
                    });
                } else {
                    g.this.c.notifyAdFailed(80001, "render fail, ksFeedAd is null");
                }
            } catch (Throwable th) {
                th.printStackTrace();
                if (this.f2562a == null) {
                    g.this.c.notifyAdFailed(80001, "render fail, ksFeedAd is null");
                    return;
                }
                Context context = (Context) g.this.e.get();
                View feedView = context != null ? this.f2562a.getFeedView(context) : null;
                if (feedView == null) {
                    g.this.c.notifyAdFailed(80001, "render fail, expressView is null");
                } else {
                    this.b = feedView;
                    g.this.c.notifyAdSuccess(this, this.mGMAd);
                }
            }
        }

        private String e() {
            return g.this.d ? f() : g();
        }

        private String f() {
            try {
                return (String) o.a(new Callable<String>() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.b.4
                    @Override // java.util.concurrent.Callable
                    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
                    public String call() {
                        return b.this.g();
                    }
                }).get(500L, TimeUnit.MILLISECONDS);
            } catch (Throwable th) {
                th.printStackTrace();
                return null;
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public String g() {
            Object obj;
            try {
                KsFeedAd ksFeedAd = this.f2562a;
                if (ksFeedAd == null || (obj = ksFeedAd.getMediaExtraInfo().get("llsid")) == null) {
                    return null;
                }
                return obj.toString();
            } catch (Throwable unused) {
                return null;
            }
        }

        public void a() {
            if (g.this.d) {
                c();
            } else {
                d();
            }
        }

        @Override // com.bytedance.msdk.adapter.ks.base.proto.AdnAdapterBaseFunction
        public <T> T applyFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
            if (i == 6081) {
                return (T) b();
            }
            if (i == 8121) {
                return (T) isReadyStatusForProto2(isReadyStatus(), sparseArray, cls);
            }
            if (i == 8120) {
                return (T) Boolean.valueOf(hasDestroyed());
            }
            if (i == 8109) {
                onDestroy();
            } else {
                if (i == 8147) {
                    return (T) e();
                }
                if (i == 8142) {
                    if (p.a(this.f2562a)) {
                        Map map = (Map) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveCacheThresholdHttpToP2p), Map.class, null);
                        MediationApiLog.i("-------ks_bid_win --------- map = " + map);
                        if (map != null) {
                            long jA = p.a((Map<String, Object>) map);
                            long jB = p.b((Map<String, Object>) map);
                            MediationApiLog.i("-------ks_bid_win --------- bidEcpm = " + jA + " loseBidEcpm = " + jB);
                            KsFeedAd ksFeedAd = this.f2562a;
                            if (ksFeedAd != null) {
                                ksFeedAd.setBidEcpm(jA, jB);
                            }
                        }
                    }
                } else if (i == 8144 && p.b(this.f2562a)) {
                    Map map2 = (Map) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveCacheThresholdHttpToP2p), Map.class, null);
                    MediationApiLog.i("-------ks_bid_lose --------- map = " + map2);
                    if (map2 != null) {
                        int iC = p.c(map2);
                        int iD = p.d(map2);
                        int iE = p.e(map2);
                        String strF = p.f(map2);
                        MediationApiLog.i("-------ks_bid_lose --------- bidEcpm = " + iD + " failureCode = " + iC);
                        if (this.f2562a != null) {
                            AdExposureFailedReason adExposureFailedReason = new AdExposureFailedReason();
                            adExposureFailedReason.setWinEcpm(iD);
                            adExposureFailedReason.setAdnType(iE);
                            adExposureFailedReason.setAdnName(strF);
                            this.f2562a.reportAdExposureFailed(iC, adExposureFailedReason);
                        }
                    }
                }
            }
            return (T) MediationValueUtil.checkClassType(cls);
        }

        @JProtect
        public View b() {
            return this.b;
        }

        @Override // com.bykv.vk.openvk.api.proto.Caller
        public <T> T call(int i, ValueSet valueSet, Class<T> cls) {
            return (T) applyFunction(i, AdnAdapterValueSetBuilder.converToSparseArray(valueSet), cls);
        }

        @Override // com.bytedance.msdk.adapter.ks.base.proto.MediationBaseAdBridge
        public boolean hasDestroyed() {
            return false;
        }

        @Override // com.bytedance.msdk.adapter.ks.base.proto.MediationBaseAdBridge
        public void onDestroy() {
        }

        @Override // com.bykv.vk.openvk.api.proto.Bridge
        public ValueSet values() {
            return null;
        }
    }

    class c extends MediationBaseAdBridge {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        KsNativeAd f2567a;
        KsNativeAd.AdInteractionListener b;
        KsNativeAd.VideoPlayListener c;

        public c(KsNativeAd ksNativeAd, MediationAdSlotValueSet mediationAdSlotValueSet, Function function) {
            KsImage videoCoverImage;
            super(mediationAdSlotValueSet, function);
            this.b = new KsNativeAd.AdInteractionListener() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.c.2
                @Override // com.kwad.sdk.api.KsNativeAd.AdInteractionListener
                public boolean handleDownloadDialog(DialogInterface.OnClickListener onClickListener) {
                    return false;
                }

                @Override // com.kwad.sdk.api.KsNativeAd.AdInteractionListener
                @JProtect
                public void onAdClicked(View view, KsNativeAd ksNativeAd2) {
                    if (c.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_VERTICAL_TEXT));
                        sparseArray.put(-99999985, Void.class);
                        c.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.kwad.sdk.api.KsNativeAd.AdInteractionListener
                @JProtect
                public void onAdShow(KsNativeAd ksNativeAd2) {
                    if (c.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_TEXT));
                        sparseArray.put(-99999985, Void.class);
                        c.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.kwad.sdk.api.KsNativeAd.AdInteractionListener
                public void onDownloadTipsDialogDismiss() {
                }

                @Override // com.kwad.sdk.api.KsNativeAd.AdInteractionListener
                public void onDownloadTipsDialogShow() {
                }
            };
            this.c = new KsNativeAd.VideoPlayListener() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.c.3
                @Override // com.kwad.sdk.api.KsNativeAd.VideoPlayListener
                @JProtect
                public void onVideoPlayComplete() {
                }

                @Override // com.kwad.sdk.api.KsNativeAd.VideoPlayListener
                @JProtect
                public void onVideoPlayError(int i, int i2) {
                }

                @Override // com.kwad.sdk.api.KsNativeAd.VideoPlayListener
                public void onVideoPlayPause() {
                }

                @Override // com.kwad.sdk.api.KsNativeAd.VideoPlayListener
                public void onVideoPlayReady() {
                }

                @Override // com.kwad.sdk.api.KsNativeAd.VideoPlayListener
                public void onVideoPlayResume() {
                }

                @Override // com.kwad.sdk.api.KsNativeAd.VideoPlayListener
                @JProtect
                public void onVideoPlayStart() {
                }
            };
            this.f2567a = ksNativeAd;
            SparseArray sparseArray = new SparseArray();
            sparseArray.put(8033, false);
            sparseArray.put(8061, this.f2567a.getActionDescription());
            sparseArray.put(8046, this.f2567a.getAdDescription());
            sparseArray.put(8048, this.f2567a.getAppIconUrl());
            String appName = !TextUtils.isEmpty(this.f2567a.getAppName()) ? this.f2567a.getAppName() : !TextUtils.isEmpty(this.f2567a.getProductName()) ? this.f2567a.getProductName() : "";
            sparseArray.put(8049, appName);
            sparseArray.put(8045, this.f2567a.getAdSource());
            sparseArray.put(8055, Boolean.valueOf(this.f2567a.getInteractionType() == 1));
            sparseArray.put(8082, Double.valueOf(this.f2567a.getAppScore()));
            sparseArray.put(8056, appName);
            sparseArray.put(8057, this.f2567a.getCorporationName());
            sparseArray.put(8047, Integer.valueOf((int) this.f2567a.getAppPackageSize()));
            sparseArray.put(8078, Long.valueOf(this.f2567a.getAppPackageSize()));
            sparseArray.put(8081, this.f2567a.getAppVersion());
            sparseArray.put(8079, this.f2567a.getPermissionInfoUrl());
            sparseArray.put(8080, this.f2567a.getAppPrivacyUrl());
            try {
                sparseArray.put(8551, this.f2567a.getIntroductionInfoUrl());
            } catch (Throwable th) {
                th.printStackTrace();
            }
            sparseArray.put(8059, Integer.valueOf(p.a(this.f2567a.getInteractionType())));
            if (g.this.c.isClientBidding()) {
                sparseArray.put(8016, Double.valueOf(Math.max(this.f2567a.getECPM(), 0.0d)));
            }
            if (this.f2567a.getMaterialType() == 2) {
                if (this.f2567a.getImageList() != null && !this.f2567a.getImageList().isEmpty() && this.f2567a.getImageList().get(0) != null) {
                    sparseArray.put(8060, 3);
                    videoCoverImage = this.f2567a.getImageList().get(0);
                    sparseArray.put(8050, videoCoverImage.getImageUrl());
                    sparseArray.put(8051, Integer.valueOf(videoCoverImage.getHeight()));
                    sparseArray.put(8052, Integer.valueOf(videoCoverImage.getWidth()));
                }
            } else if (this.f2567a.getMaterialType() == 3) {
                if (this.f2567a.getImageList() != null && this.f2567a.getImageList().size() > 0) {
                    sparseArray.put(8060, 4);
                    ArrayList arrayList = new ArrayList();
                    Iterator<KsImage> it = this.f2567a.getImageList().iterator();
                    while (it.hasNext()) {
                        arrayList.add(it.next().getImageUrl());
                    }
                    sparseArray.put(8053, arrayList);
                }
            } else if (this.f2567a.getMaterialType() == 1 || this.f2567a.getMaterialType() == 8) {
                sparseArray.put(8060, 5);
                videoCoverImage = this.f2567a.getVideoCoverImage();
                if (videoCoverImage == null && this.f2567a.getImageList() != null && !this.f2567a.getImageList().isEmpty() && this.f2567a.getImageList().get(0) != null) {
                    videoCoverImage = this.f2567a.getImageList().get(0);
                }
                if (videoCoverImage != null) {
                    sparseArray.put(8050, videoCoverImage.getImageUrl());
                    sparseArray.put(8051, Integer.valueOf(videoCoverImage.getHeight()));
                    sparseArray.put(8052, Integer.valueOf(videoCoverImage.getWidth()));
                }
            } else {
                sparseArray.put(8060, -1);
            }
            sparseArray.put(-99999987, 8140);
            sparseArray.put(-99999985, Void.class);
            function.apply(sparseArray);
            this.f2567a.setVideoPlayListener(this.c);
        }

        /* JADX INFO: Access modifiers changed from: private */
        public void a() {
            KsNativeAd ksNativeAd = this.f2567a;
            if (ksNativeAd != null) {
                ksNativeAd.setVideoPlayListener(null);
                this.f2567a = null;
            }
        }

        private void b() {
            o.b(new Runnable() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.c.1
                @Override // java.lang.Runnable
                public void run() {
                    c.this.a();
                }
            });
        }

        private String c() {
            return g.this.d ? d() : e();
        }

        private String d() {
            try {
                return (String) o.a(new Callable<String>() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.c.4
                    @Override // java.util.concurrent.Callable
                    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
                    public String call() {
                        return c.this.e();
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
                KsNativeAd ksNativeAd = this.f2567a;
                if (ksNativeAd == null || (obj = ksNativeAd.getMediaExtraInfo().get("llsid")) == null) {
                    return null;
                }
                return obj.toString();
            } catch (Throwable unused) {
                return null;
            }
        }

        @JProtect
        public void a(Context context, ViewGroup viewGroup, List<View> list, List<View> list2, MediationViewBinder mediationViewBinder) {
            View viewFindViewById;
            if (list != null && list2 != null) {
                list.addAll(list2);
            }
            KsNativeAd ksNativeAd = this.f2567a;
            if (ksNativeAd != null) {
                ksNativeAd.registerViewForInteraction(viewGroup, list, this.b);
            }
            KsNativeAd ksNativeAd2 = this.f2567a;
            boolean z = false;
            if (ksNativeAd2 != null && ksNativeAd2.getAdSourceLogoUrl(1) != null && (viewFindViewById = viewGroup.findViewById(mediationViewBinder.logoLayoutId)) != null) {
                viewFindViewById.setVisibility(0);
                if (viewFindViewById instanceof ViewGroup) {
                    ViewGroup viewGroup2 = (ViewGroup) viewFindViewById;
                    viewGroup2.removeAllViews();
                    ImageView imageView = new ImageView(context);
                    new com.h7brb.h7brb.h7brb.h7brb.h7brb.a(imageView).execute(this.f2567a.getAdSourceLogoUrl(1));
                    imageView.setScaleType(ImageView.ScaleType.CENTER_INSIDE);
                    viewGroup2.addView(imageView, -1, -1);
                } else if (viewFindViewById instanceof ImageView) {
                    ImageView imageView2 = (ImageView) viewFindViewById;
                    new com.h7brb.h7brb.h7brb.h7brb.h7brb.a(imageView2).execute(this.f2567a.getAdSourceLogoUrl(1));
                    imageView2.setScaleType(ImageView.ScaleType.CENTER_INSIDE);
                }
            }
            ViewGroup viewGroup3 = (ViewGroup) viewGroup.findViewById(mediationViewBinder.mediaViewId);
            if (this.f2567a == null || viewGroup3 == null) {
                return;
            }
            KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl = new KSAdVideoPlayConfigImpl();
            if (g.this.f2554a != null && !g.this.f2554a.isMuted()) {
                z = true;
            }
            kSAdVideoPlayConfigImpl.setVideoSoundEnable(z);
            View videoView = this.f2567a.getVideoView(context, kSAdVideoPlayConfigImpl);
            if (videoView == null) {
                return;
            }
            g.this.c.removeSelfFromParent(videoView);
            viewGroup3.removeAllViews();
            viewGroup3.addView(videoView, -1, -1);
        }

        @Override // com.bytedance.msdk.adapter.ks.base.proto.AdnAdapterBaseFunction
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
                final Object objObjectValue = MediationValueUtil.objectValue(sparseArray.get(8071), Object.class, null);
                if (g.this.d) {
                    o.b(new Runnable() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.c.5
                        @Override // java.lang.Runnable
                        public void run() {
                            c.this.a(activity, viewGroup, list, list2, p.a(AdnAdapterBridgeWrapper.covertToFunction(objObjectValue)));
                        }
                    });
                } else {
                    a(activity, viewGroup, list, list2, p.a(AdnAdapterBridgeWrapper.covertToFunction(objObjectValue)));
                }
            } else if (i == 8109) {
                onDestroy();
            } else {
                if (i == 8147) {
                    return (T) c();
                }
                if (i == 8142) {
                    if (p.a(this.f2567a)) {
                        Map map = (Map) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveCacheThresholdHttpToP2p), Map.class, null);
                        MediationApiLog.i("-------ks_bid_win --------- map = " + map);
                        if (map != null) {
                            long jA = p.a((Map<String, Object>) map);
                            long jB = p.b((Map<String, Object>) map);
                            MediationApiLog.i("-------ks_bid_win --------- bidEcpm = " + jA + " loseBidEcpm = " + jB);
                            KsNativeAd ksNativeAd = this.f2567a;
                            if (ksNativeAd != null) {
                                ksNativeAd.setBidEcpm(jA, jB);
                            }
                        }
                    }
                } else if (i == 8144 && p.b(this.f2567a)) {
                    Map map2 = (Map) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveCacheThresholdHttpToP2p), Map.class, null);
                    MediationApiLog.i("-------ks_bid_lose --------- map = " + map2);
                    if (map2 != null) {
                        int iC = p.c(map2);
                        int iD = p.d(map2);
                        int iE = p.e(map2);
                        String strF = p.f(map2);
                        MediationApiLog.i("-------ks_bid_lose --------- bidEcpm = " + iD + " failureCode = " + iC);
                        if (this.f2567a != null) {
                            AdExposureFailedReason adExposureFailedReason = new AdExposureFailedReason();
                            adExposureFailedReason.setWinEcpm(iD);
                            adExposureFailedReason.setAdnType(iE);
                            adExposureFailedReason.setAdnName(strF);
                            this.f2567a.reportAdExposureFailed(iC, adExposureFailedReason);
                        }
                    }
                }
            }
            return (T) MediationValueUtil.checkClassType(cls);
        }

        @Override // com.bykv.vk.openvk.api.proto.Caller
        public <T> T call(int i, ValueSet valueSet, Class<T> cls) {
            return (T) applyFunction(i, AdnAdapterValueSetBuilder.converToSparseArray(valueSet), cls);
        }

        @Override // com.bytedance.msdk.adapter.ks.base.proto.MediationBaseAdBridge
        public boolean hasDestroyed() {
            return this.f2567a == null;
        }

        @Override // com.bytedance.msdk.adapter.ks.base.proto.MediationBaseAdBridge
        public void onDestroy() {
            if (g.this.d) {
                b();
            } else {
                a();
            }
        }

        @Override // com.bykv.vk.openvk.api.proto.Bridge
        public ValueSet values() {
            return null;
        }
    }

    public g(KsBannerLoader ksBannerLoader) {
        this.c = ksBannerLoader;
    }

    @JProtect
    private void a(KsScene ksScene) {
        KsAdSDK.getLoadManager().loadBannerAd(ksScene, new KsLoadManager.BannerAdListener() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.2
            @Override // com.kwad.sdk.api.KsLoadManager.BannerAdListener
            public void onBannerAdLoad(KsBannerAd ksBannerAd) {
                if (ksBannerAd == null) {
                    g.this.c.notifyAdFailed(80001, "load成功，返回为空");
                    return;
                }
                g gVar = g.this;
                g.this.c.notifyAdSuccess(gVar.new a(ksBannerAd, gVar.f2554a, g.this.b), g.this.b);
            }

            @Override // com.kwad.sdk.api.KsLoadManager.BannerAdListener
            public void onError(int i, String str) {
                g.this.c.notifyAdFailed(i, str);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(Context context, MediationAdSlotValueSet mediationAdSlotValueSet) {
        KsBannerLoader ksBannerLoader;
        String str;
        if (context == null || mediationAdSlotValueSet == null) {
            ksBannerLoader = this.c;
            str = "context is null or adSlotValueSet is null";
        } else {
            this.f2554a = mediationAdSlotValueSet;
            this.b = this.c.getGMBridge();
            try {
                KsScene.Builder builderAdNum = new KsScene.Builder(Long.valueOf(this.c.getAdnId()).longValue()).adNum(1);
                f.a(builderAdNum, mediationAdSlotValueSet, "BANNER");
                KsScene ksSceneBuild = builderAdNum.build();
                if (mediationAdSlotValueSet.getAdSubType() != 4) {
                    a(ksSceneBuild);
                    return;
                }
                int originType = mediationAdSlotValueSet.getOriginType();
                if (originType == 1) {
                    float expressWidth = mediationAdSlotValueSet.getExpressWidth();
                    if (context != null && expressWidth > 0.0f) {
                        ksSceneBuild.setWidth((int) p.a(context, expressWidth));
                    }
                    b(ksSceneBuild);
                    return;
                }
                if (originType == 2) {
                    c(ksSceneBuild);
                    return;
                } else {
                    ksBannerLoader = this.c;
                    str = "广告类型错误";
                }
            } catch (Exception unused) {
                this.c.notifyAdFailed(80001, "广告位id错误");
                return;
            }
        }
        ksBannerLoader.notifyAdFailed(80001, str);
    }

    @JProtect
    private void b(KsScene ksScene) {
        KsAdSDK.getLoadManager().loadConfigFeedAd(ksScene, new KsLoadManager.FeedAdListener() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.3
            @Override // com.kwad.sdk.api.KsLoadManager.FeedAdListener
            public void onError(int i, String str) {
                g.this.c.notifyAdFailed(i, str);
            }

            @Override // com.kwad.sdk.api.KsLoadManager.FeedAdListener
            public void onFeedAdLoad(List<KsFeedAd> list) {
                if (list == null || list.isEmpty()) {
                    g.this.c.notifyAdFailed(80001, "load成功，list为空");
                    return;
                }
                for (KsFeedAd ksFeedAd : list) {
                    if (ksFeedAd != null) {
                        g gVar = g.this;
                        gVar.new b(ksFeedAd, gVar.f2554a, g.this.b).a();
                        return;
                    }
                }
            }
        });
    }

    @JProtect
    private void c(KsScene ksScene) {
        KsAdSDK.getLoadManager().loadNativeAd(ksScene, new KsLoadManager.NativeAdListener() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.4
            @Override // com.kwad.sdk.api.KsLoadManager.NativeAdListener
            public void onError(int i, String str) {
                g.this.c.notifyAdFailed(i, str);
            }

            @Override // com.kwad.sdk.api.KsLoadManager.NativeAdListener
            public void onNativeAdLoad(List<KsNativeAd> list) {
                if (list == null || list.isEmpty()) {
                    g.this.c.notifyAdFailed(80001, "load成功，list为空");
                    return;
                }
                for (KsNativeAd ksNativeAd : list) {
                    if (ksNativeAd != null) {
                        KsBannerLoader ksBannerLoader = g.this.c;
                        g gVar = g.this;
                        ksBannerLoader.notifyAdSuccess(gVar.new c(ksNativeAd, gVar.f2554a, g.this.b), g.this.b);
                        return;
                    }
                }
            }
        });
    }

    public void a(final Context context, final MediationAdSlotValueSet mediationAdSlotValueSet) {
        this.e = new WeakReference<>(context);
        boolean zA = p.a(this.c, mediationAdSlotValueSet);
        this.d = zA;
        if (zA) {
            o.a(new Runnable() { // from class: com.h7brb.h7brb.h7brb.h7brb.h7brb.g.1
                @Override // java.lang.Runnable
                public void run() {
                    g.this.b(context.getApplicationContext(), mediationAdSlotValueSet);
                    o.a(getClass().getName(), context.getApplicationContext());
                }
            });
        } else {
            b(context.getApplicationContext(), mediationAdSlotValueSet);
        }
    }
}
