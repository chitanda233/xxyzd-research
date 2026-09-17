package com.bytedance.msdk.adapter.sigmob;

import android.app.Activity;
import android.content.Context;
import android.text.TextUtils;
import android.util.SparseArray;
import androidx.core.view.PointerIconCompat;
import com.bykv.vk.openvk.api.proto.ValueSet;
import com.bytedance.JProtect;
import com.bytedance.msdk.adapter.sigmob.base.MediationAdLoaderBaseFunction;
import com.bytedance.msdk.adapter.sigmob.base.config.MediationAdSlotValueSet;
import com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterValueSetBuilder;
import com.bytedance.msdk.adapter.sigmob.base.proto.MediationBaseAdBridge;
import com.bytedance.msdk.adapter.sigmob.base.utils.MediationApiLog;
import com.bytedance.msdk.adapter.sigmob.base.utils.MediationValueUtil;
import com.sigmob.sdk.base.models.WindAdMetaData;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.newInterstitial.WindNewInterstitialAd;
import com.sigmob.windad.newInterstitial.WindNewInterstitialAdListener;
import com.sigmob.windad.newInterstitial.WindNewInterstitialAdRequest;
import java.util.HashMap;
import java.util.function.Function;

/* JADX INFO: loaded from: classes2.dex */
public class SigmobFullVideoLoader extends MediationAdLoaderBaseFunction {

    class SigMobFulllAd extends MediationBaseAdBridge {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        WindNewInterstitialAdListener f1877a;
        private WindNewInterstitialAd c;
        private boolean d;

        public SigMobFulllAd(MediationAdSlotValueSet mediationAdSlotValueSet, Function function) {
            super(mediationAdSlotValueSet, function);
            this.f1877a = new WindNewInterstitialAdListener() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobFullVideoLoader.SigMobFulllAd.1
                @Override // com.sigmob.windad.newInterstitial.WindNewInterstitialAdListener
                public void onInterstitialAdClicked(String str) {
                    MediationApiLog.i("TTMediationSDK", "SigmobFullVideoLoader onInterstitialAdClicked ");
                    if (SigMobFulllAd.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_VERTICAL_TEXT));
                        sparseArray.put(-99999985, Void.class);
                        SigMobFulllAd.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.sigmob.windad.newInterstitial.WindNewInterstitialAdListener
                public void onInterstitialAdClosed(String str) {
                    MediationApiLog.i("TTMediationSDK", "SigmobFullVideoLoader onInterstitialAdClosed ");
                    if (SigMobFulllAd.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_HORIZONTAL_DOUBLE_ARROW));
                        sparseArray.put(-99999985, Void.class);
                        SigMobFulllAd.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.sigmob.windad.newInterstitial.WindNewInterstitialAdListener
                public void onInterstitialAdLoadError(WindAdError windAdError, String str) {
                    SigMobFulllAd.this.d = false;
                    if (windAdError != null) {
                        MediationApiLog.i("TTMediationSDK", "SigmobFullVideoLoader onInterstitialAdLoadError error_code:" + windAdError.getErrorCode() + " msg:" + windAdError.getMessage());
                        SigmobFullVideoLoader.this.notifyAdFailed(windAdError.getErrorCode(), windAdError.getMessage());
                    } else {
                        MediationApiLog.i("TTMediationSDK", "SigmobFullVideoLoader onInterstitialAdLoadError");
                        SigmobFullVideoLoader.this.notifyAdFailed(80001, "加载失败");
                    }
                }

                @Override // com.sigmob.windad.newInterstitial.WindNewInterstitialAdListener
                public void onInterstitialAdLoadSuccess(String str) {
                    MediationApiLog.i("TTMediationSDK", "SigmobFullVideoLoader onInterstitialAdLoadSuccess ");
                    SigMobFulllAd.this.setExpress();
                    SigMobFulllAd.this.d = true;
                    SigmobFullVideoLoader.this.notifyAdCache(SigMobFulllAd.this.mGMAd, -1, "");
                }

                @Override // com.sigmob.windad.newInterstitial.WindNewInterstitialAdListener
                public void onInterstitialAdPreLoadFail(String str) {
                    MediationApiLog.i("TTMediationSDK", "SigmobFullVideoLoader onInterstitialAdPreLoadFail s:" + str);
                }

                @Override // com.sigmob.windad.newInterstitial.WindNewInterstitialAdListener
                public void onInterstitialAdPreLoadSuccess(String str) {
                    MediationApiLog.i("TTMediationSDK", "SigmobFullVideoLoader onInterstitialAdPreLoadSuccess ");
                    SigMobFulllAd.this.setExpress();
                    SigMobFulllAd.this.d = true;
                    SigmobFullVideoLoader sigmobFullVideoLoader = SigmobFullVideoLoader.this;
                    SigMobFulllAd sigMobFulllAd = SigMobFulllAd.this;
                    sigmobFullVideoLoader.notifyAdSuccess(sigMobFulllAd, sigMobFulllAd.mGMAd);
                }

                @Override // com.sigmob.windad.newInterstitial.WindNewInterstitialAdListener
                public void onInterstitialAdShow(String str) {
                    MediationApiLog.i("TTMediationSDK", "SigmobFullVideoLoader onInterstitialAdShow s:" + str);
                    if (SigMobFulllAd.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_TEXT));
                        sparseArray.put(-99999985, Void.class);
                        SigMobFulllAd.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.sigmob.windad.newInterstitial.WindNewInterstitialAdListener
                public void onInterstitialAdShowError(WindAdError windAdError, String str) {
                    MediationApiLog.i("TTMediationSDK", "SigmobFullVideoLoader onInterstitialAdShowError ");
                    if (SigMobFulllAd.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, Integer.valueOf(PointerIconCompat.TYPE_TOP_LEFT_DIAGONAL_DOUBLE_ARROW));
                        sparseArray.put(-99999985, Void.class);
                        sparseArray.put(8014, Integer.valueOf(windAdError != null ? windAdError.getErrorCode() : 0));
                        sparseArray.put(8015, windAdError != null ? windAdError.getMessage() : "广告展示失败");
                        SigMobFulllAd.this.mGMAd.apply(sparseArray);
                    }
                }
            };
        }

        /* JADX WARN: Type inference failed for: r3v2, types: [T, java.util.HashMap, java.util.Map] */
        @Override // com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterBaseFunction
        public <T> T applyFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
            if (i == 8113) {
                MediationApiLog.i("TTMediationSDK", "SigmobFullVideoLoader showAd");
                Activity activity = (Activity) MediationValueUtil.objectValue(sparseArray.get(20033), Activity.class, null);
                if (activity != null) {
                    showAd(activity);
                }
            } else if (i == 8109) {
                onDestroy();
            } else {
                if (i == 8120) {
                    return (T) Boolean.valueOf(hasDestroyed());
                }
                if (i == 8121) {
                    return (T) isReadyStatusForProto2(isReadyStatus(), sparseArray, cls);
                }
                if (i == 8239) {
                    try {
                        WindAdMetaData windAdMetaData = this.c.getWindAdMetaData();
                        if (windAdMetaData != null) {
                            ?? r3 = (T) new HashMap();
                            r3.put("adid", windAdMetaData.getAdId());
                            return r3;
                        }
                    } catch (Throwable th) {
                        th.printStackTrace();
                    }
                }
            }
            return (T) MediationValueUtil.checkClassType(cls);
        }

        @Override // com.bykv.vk.openvk.api.proto.Caller
        public <T> T call(int i, ValueSet valueSet, Class<T> cls) {
            return (T) applyFunction(i, AdnAdapterValueSetBuilder.converToSparseArray(valueSet), cls);
        }

        @Override // com.bytedance.msdk.adapter.sigmob.base.proto.MediationBaseAdBridge
        public boolean hasDestroyed() {
            return this.c == null;
        }

        @Override // com.bytedance.msdk.adapter.sigmob.base.proto.MediationBaseAdBridge
        public Integer isReadyStatus() {
            WindNewInterstitialAd windNewInterstitialAd = this.c;
            return Integer.valueOf((windNewInterstitialAd == null || !windNewInterstitialAd.isReady()) ? 4 : 2);
        }

        @JProtect
        public void loadAd() {
            WindNewInterstitialAd windNewInterstitialAd = new WindNewInterstitialAd(new WindNewInterstitialAdRequest(SigmobFullVideoLoader.this.getAdnId(), getUserID(), null));
            this.c = windNewInterstitialAd;
            windNewInterstitialAd.setWindNewInterstitialAdListener(this.f1877a);
            if (TextUtils.isEmpty(SigmobFullVideoLoader.this.getAdm())) {
                MediationApiLog.i("TTMediationSDK", "SigmobFullVideoLoader loadAd...loadAd start....");
                this.c.loadAd();
            } else {
                MediationApiLog.i("TTMediationSDK", "SigmobFullVideoLoader loadBidAd...loadAd start....");
                this.c.loadAd(SigmobFullVideoLoader.this.getAdm());
            }
        }

        @Override // com.bytedance.msdk.adapter.sigmob.base.proto.MediationBaseAdBridge
        public void onDestroy() {
            WindNewInterstitialAd windNewInterstitialAd = this.c;
            if (windNewInterstitialAd != null) {
                windNewInterstitialAd.setWindNewInterstitialAdListener(null);
                this.c = null;
            }
        }

        @JProtect
        public void showAd(Activity activity) {
            try {
                MediationApiLog.i("TTMediationSDK", "SigmobFullVideoLoader showAd");
                WindNewInterstitialAd windNewInterstitialAd = this.c;
                if (windNewInterstitialAd != null) {
                    windNewInterstitialAd.show(null);
                }
            } catch (IllegalArgumentException e) {
                e.printStackTrace();
            }
        }

        @Override // com.bykv.vk.openvk.api.proto.Bridge
        public ValueSet values() {
            return null;
        }
    }

    @Override // com.bytedance.msdk.adapter.sigmob.base.MediationAdLoaderBaseFunction
    public void realLoader(Context context, MediationAdSlotValueSet mediationAdSlotValueSet) {
        MediationApiLog.i("TTMediationSDK", "SigmobFullVideoLoader realLoader adnId:" + getAdnId());
        new SigMobFulllAd(mediationAdSlotValueSet, getGMBridge()).loadAd();
    }
}
