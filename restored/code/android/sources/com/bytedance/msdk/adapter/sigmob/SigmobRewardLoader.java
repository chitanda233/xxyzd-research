package com.bytedance.msdk.adapter.sigmob;

import android.app.Activity;
import android.content.Context;
import android.text.TextUtils;
import android.util.SparseArray;
import com.bykv.vk.openvk.api.proto.ValueSet;
import com.bytedance.JProtect;
import com.bytedance.msdk.adapter.sigmob.base.config.MediationAdSlotValueSet;
import com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterValueSetBuilder;
import com.bytedance.msdk.adapter.sigmob.base.proto.MediationBaseAdBridge;
import com.bytedance.msdk.adapter.sigmob.base.utils.MediationApiLog;
import com.bytedance.msdk.adapter.sigmob.base.utils.MediationValueUtil;
import com.sigmob.sdk.base.models.WindAdMetaData;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.rewardVideo.WindRewardAdRequest;
import com.sigmob.windad.rewardVideo.WindRewardInfo;
import com.sigmob.windad.rewardVideo.WindRewardVideoAd;
import com.sigmob.windad.rewardVideo.WindRewardVideoAdListener;
import java.util.HashMap;
import java.util.Map;
import java.util.function.Function;

/* JADX INFO: loaded from: classes2.dex */
public class SigmobRewardLoader extends SigmobBaseLoader {
    public static final String TAG = "SigmobRewardVideoAdapter";

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private SigmobRewardVideo f1889a;
    private MediationAdSlotValueSet b;
    private Function c;

    class SigmobRewardVideo extends MediationBaseAdBridge {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        WindRewardVideoAdListener f1890a;
        private WindRewardVideoAd c;

        SigmobRewardVideo() {
            super(SigmobRewardLoader.this.b, SigmobRewardLoader.this.c);
            this.f1890a = new WindRewardVideoAdListener() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobRewardLoader.SigmobRewardVideo.1
                @Override // com.sigmob.windad.rewardVideo.WindRewardVideoAdListener
                @JProtect
                public void onRewardAdClicked(String str) {
                    if (SigmobRewardVideo.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, 8115);
                        sparseArray.put(-99999985, Void.class);
                        SigmobRewardVideo.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.sigmob.windad.rewardVideo.WindRewardVideoAdListener
                @JProtect
                public void onRewardAdClosed(String str) {
                    if (SigmobRewardVideo.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, 8116);
                        sparseArray.put(-99999985, Void.class);
                        SigmobRewardVideo.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.sigmob.windad.rewardVideo.WindRewardVideoAdListener
                @JProtect
                public void onRewardAdLoadError(WindAdError windAdError, String str) {
                    if (windAdError == null) {
                        SigmobRewardLoader.this.notifyAdFailed(80001, "load失败:" + str);
                    } else {
                        MediationApiLog.i("TMe", "sigmob reward load fail: " + windAdError.getErrorCode() + ", " + windAdError.getMessage());
                        SigmobRewardLoader.this.notifyAdFailed(windAdError.getErrorCode(), windAdError.getMessage());
                    }
                }

                @Override // com.sigmob.windad.rewardVideo.WindRewardVideoAdListener
                @JProtect
                public void onRewardAdLoadSuccess(String str) {
                    SigmobRewardLoader.this.notifyAdCache(SigmobRewardVideo.this.mGMAd, -1, "");
                }

                @Override // com.sigmob.windad.rewardVideo.WindRewardVideoAdListener
                @JProtect
                public void onRewardAdPlayEnd(String str) {
                    if (SigmobRewardVideo.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, 8118);
                        sparseArray.put(-99999985, Void.class);
                        SigmobRewardVideo.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.sigmob.windad.rewardVideo.WindRewardVideoAdListener
                @JProtect
                public void onRewardAdPlayError(WindAdError windAdError, String str) {
                    if (SigmobRewardVideo.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, 8117);
                        sparseArray.put(-99999985, Void.class);
                        SigmobRewardVideo.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.sigmob.windad.rewardVideo.WindRewardVideoAdListener
                @JProtect
                public void onRewardAdPlayStart(String str) {
                    if (SigmobRewardVideo.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, 8230);
                        sparseArray.put(-99999985, Void.class);
                        SigmobRewardVideo.this.mGMAd.apply(sparseArray);
                    }
                }

                @Override // com.sigmob.windad.rewardVideo.WindRewardVideoAdListener
                @JProtect
                public void onRewardAdPreLoadFail(String str) {
                    MediationApiLog.i("TMe", "sigmob reward onRewardAdPreLoadFail: " + str);
                }

                @Override // com.sigmob.windad.rewardVideo.WindRewardVideoAdListener
                @JProtect
                public void onRewardAdPreLoadSuccess(String str) {
                    SigmobRewardLoader sigmobRewardLoader = SigmobRewardLoader.this;
                    SigmobRewardVideo sigmobRewardVideo = SigmobRewardVideo.this;
                    sigmobRewardLoader.notifyAdSuccess(sigmobRewardVideo, sigmobRewardVideo.mGMAd);
                }

                @Override // com.sigmob.windad.rewardVideo.WindRewardVideoAdListener
                @JProtect
                public void onRewardAdRewarded(WindRewardInfo windRewardInfo, String str) {
                    if (SigmobRewardVideo.this.mGMAd != null) {
                        SparseArray<Object> sparseArray = new SparseArray<>();
                        sparseArray.put(-99999987, 8231);
                        sparseArray.put(-99999985, Void.class);
                        sparseArray.put(8017, Boolean.valueOf(windRewardInfo != null && windRewardInfo.isReward()));
                        sparseArray.put(8018, Integer.valueOf(SigmobRewardLoader.this.b.getRewardAmount()));
                        sparseArray.put(8019, SigmobRewardLoader.this.b.getRewardName());
                        sparseArray.put(8020, windRewardInfo != null ? windRewardInfo.getOptions() : new HashMap<>(0));
                        SigmobRewardVideo.this.mGMAd.apply(sparseArray);
                    }
                }
            };
        }

        /* JADX INFO: Access modifiers changed from: private */
        @JProtect
        public void a() {
            WindRewardVideoAd windRewardVideoAd = new WindRewardVideoAd(new WindRewardAdRequest(SigmobRewardLoader.this.getAdnId(), SigmobRewardLoader.this.b.getUserId(), b()));
            this.c = windRewardVideoAd;
            windRewardVideoAd.setWindRewardVideoAdListener(this.f1890a);
            if (TextUtils.isEmpty(SigmobRewardLoader.this.getAdm())) {
                this.c.loadAd();
            } else {
                this.c.loadAd(SigmobRewardLoader.this.getAdm());
            }
        }

        private Map<String, Object> b() {
            HashMap map = new HashMap();
            Map<String, Object> extraObject = SigmobRewardLoader.this.b.getExtraObject();
            if (extraObject != null && extraObject.get("sigmob") != null) {
                map.put("extraData", String.valueOf(extraObject.get("sigmob")));
            }
            return map;
        }

        public boolean adnHasAdVideoCachedApi() {
            return true;
        }

        /* JADX WARN: Type inference failed for: r3v3, types: [T, java.util.HashMap, java.util.Map] */
        @Override // com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterBaseFunction
        public <T> T applyFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
            if (i == 8113) {
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
                if (i == 8211) {
                    return (T) Boolean.valueOf(adnHasAdVideoCachedApi());
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
            WindRewardVideoAd windRewardVideoAd = this.c;
            return Integer.valueOf((windRewardVideoAd == null || !windRewardVideoAd.isReady()) ? 4 : 2);
        }

        @Override // com.bytedance.msdk.adapter.sigmob.base.proto.MediationBaseAdBridge
        public void onDestroy() {
            WindRewardVideoAd windRewardVideoAd = this.c;
            if (windRewardVideoAd != null) {
                windRewardVideoAd.setWindRewardVideoAdListener(null);
                this.c = null;
            }
        }

        @JProtect
        public void showAd(Activity activity) {
            try {
                WindRewardVideoAd windRewardVideoAd = this.c;
                if (windRewardVideoAd != null) {
                    windRewardVideoAd.show(null);
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
        if (context == null || mediationAdSlotValueSet == null) {
            notifyAdFailed(80001, "context is null or adSlotValueSet is null");
            return;
        }
        this.b = mediationAdSlotValueSet;
        this.c = getGMBridge();
        SigmobRewardVideo sigmobRewardVideo = new SigmobRewardVideo();
        this.f1889a = sigmobRewardVideo;
        sigmobRewardVideo.a();
    }
}
