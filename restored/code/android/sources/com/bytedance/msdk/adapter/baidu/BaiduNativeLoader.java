package com.bytedance.msdk.adapter.baidu;

import android.content.Context;
import android.util.SparseArray;
import com.baidu.mobads.sdk.api.BaiduNativeManager;
import com.baidu.mobads.sdk.api.ExpressResponse;
import com.baidu.mobads.sdk.api.NativeResponse;
import com.baidu.mobads.sdk.api.RequestParameters;
import com.baidu.mobads.sdk.api.XAdNativeResponse;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import com.bykv.vk.openvk.api.proto.ValueSet;
import com.bytedance.JProtect;
import com.bytedance.msdk.adapter.baidu.base.config.MediationAdSlotValueSet;
import com.bytedance.msdk.adapter.baidu.base.utils.MediationValueUtil;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.function.Function;

/* JADX INFO: loaded from: classes2.dex */
public class BaiduNativeLoader extends BaiduBaseLoader {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private BaiduNativeManager f1801a;
    private Map<NativeResponse, BaiduNativeAd> b = new HashMap();

    private void a(final Context context, MediationAdSlotValueSet mediationAdSlotValueSet) {
        if (this.f1801a == null) {
            this.f1801a = new BaiduNativeManager(context, mediationAdSlotValueSet.getADNId());
        }
        this.f1801a.setAppSid(mediationAdSlotValueSet.getBaiduAppSid());
        this.f1801a.setCacheVideoOnlyWifi(mediationAdSlotValueSet.getBaiduCacheVideoOnlyWifi());
        BaiduNativeManager.ExpressAdListener expressAdListener = new BaiduNativeManager.ExpressAdListener() { // from class: com.bytedance.msdk.adapter.baidu.BaiduNativeLoader.1
            @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.ExpressAdListener
            public void onLpClosed() {
            }

            @JProtect
            public void onNativeFail(int i, String str) {
                BaiduNativeLoader.this.notifyAdFailed(i, str);
            }

            @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.ExpressAdListener
            @JProtect
            public void onNativeFail(int i, String str, ExpressResponse expressResponse) {
                BaiduNativeLoader.this.notifyAdFailed(i, str);
            }

            @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.ExpressAdListener
            @JProtect
            public void onNativeLoad(List<ExpressResponse> list) {
                if (list == null || list.size() <= 0) {
                    BaiduNativeLoader.this.notifyAdFailed(80001, "请求成功，但无广告可用");
                    return;
                }
                ArrayList arrayList = new ArrayList();
                for (ExpressResponse expressResponse : list) {
                    if (expressResponse != null) {
                        Function<SparseArray<Object>, Object> gMBridge = BaiduNativeLoader.this.getGMBridge();
                        new BaiduNativeExpressAd(context, expressResponse, BaiduNativeLoader.this, gMBridge);
                        arrayList.add(gMBridge);
                    }
                }
                BaiduNativeLoader.this.notifyAdSuccess(arrayList);
            }

            @JProtect
            public void onNoAd(int i, String str) {
                BaiduNativeLoader.this.notifyAdFailed(i, str);
            }

            @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.ExpressAdListener
            @JProtect
            public void onNoAd(int i, String str, ExpressResponse expressResponse) {
                BaiduNativeLoader.this.notifyAdFailed(i, str);
            }

            @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.ExpressAdListener
            public void onVideoDownloadFailed() {
            }

            @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.ExpressAdListener
            public void onVideoDownloadSuccess() {
            }
        };
        if (isServerBidding()) {
            this.f1801a.loadBidAdForExpress(getAdm(), expressAdListener);
            return;
        }
        RequestParameters requestParameters = BaiduAdapterUtil.getRequestParameters(mediationAdSlotValueSet);
        setBiddingResult(getAdnId(), isClientBidding(), requestParameters);
        this.f1801a.loadExpressAd(requestParameters, expressAdListener);
    }

    private void b(final Context context, MediationAdSlotValueSet mediationAdSlotValueSet) {
        if (this.f1801a == null) {
            this.f1801a = new BaiduNativeManager(context, mediationAdSlotValueSet.getADNId());
        }
        this.f1801a.setAppSid(mediationAdSlotValueSet.getBaiduAppSid());
        this.f1801a.setCacheVideoOnlyWifi(mediationAdSlotValueSet.getBaiduCacheVideoOnlyWifi());
        BaiduNativeManager.FeedAdListener feedAdListener = new BaiduNativeManager.FeedAdListener() { // from class: com.bytedance.msdk.adapter.baidu.BaiduNativeLoader.2
            @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.FeedAdListener
            public void onLpClosed() {
            }

            @JProtect
            public void onNativeFail(int i, String str) {
                BaiduNativeLoader.this.notifyAdFailed(i, str);
            }

            @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.FeedAdListener
            @JProtect
            public void onNativeFail(int i, String str, NativeResponse nativeResponse) {
                BaiduNativeLoader.this.notifyAdFailed(i, str);
            }

            @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.FeedAdListener
            @JProtect
            public void onNativeLoad(List<NativeResponse> list) {
                if (list == null || list.size() <= 0) {
                    BaiduNativeLoader.this.notifyAdFailed(80001, "返回广告位列表空");
                    return;
                }
                ArrayList arrayList = new ArrayList();
                for (NativeResponse nativeResponse : list) {
                    if (nativeResponse != null) {
                        Function<SparseArray<Object>, Object> gMBridge = BaiduNativeLoader.this.getGMBridge();
                        BaiduNativeLoader baiduNativeLoader = BaiduNativeLoader.this;
                        BaiduNativeLoader.this.b.put(nativeResponse, new BaiduNativeAd(context, (XAdNativeResponse) nativeResponse, baiduNativeLoader, gMBridge, baiduNativeLoader.mSlotValueSet));
                        arrayList.add(gMBridge);
                    }
                }
                BaiduNativeLoader.this.notifyAdSuccess(arrayList);
            }

            @JProtect
            public void onNoAd(int i, String str) {
                BaiduNativeLoader.this.notifyAdFailed(i, str);
            }

            @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.FeedAdListener
            @JProtect
            public void onNoAd(int i, String str, NativeResponse nativeResponse) {
                BaiduNativeLoader.this.notifyAdFailed(i, str);
            }

            @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.FeedAdListener
            public void onVideoDownloadFailed() {
            }

            @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.FeedAdListener
            public void onVideoDownloadSuccess() {
            }
        };
        if (isServerBidding()) {
            this.f1801a.loadBidAdForFeed(getAdm(), feedAdListener);
            return;
        }
        RequestParameters requestParameters = BaiduAdapterUtil.getRequestParameters(mediationAdSlotValueSet);
        setBiddingResult(getAdnId(), isClientBidding(), requestParameters);
        this.f1801a.loadFeedAd(requestParameters, feedAdListener);
    }

    @Override // com.bytedance.msdk.adapter.baidu.base.MediationAdLoaderBaseFunction
    public <T> T callFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
        return i == 8139 ? (T) String.valueOf(getBiddingToken((Context) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveWaitP2pReadyThreshold), Context.class, null), (String) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveCacheThresholdP2pToHttp), String.class, null), MediationValueUtil.objectValue(sparseArray.get(8044), Object.class, null))) : (T) MediationValueUtil.checkClassType(cls);
    }

    public String getBiddingToken(Context context, String str, Object obj) {
        if (this.f1801a == null) {
            this.f1801a = new BaiduNativeManager(context, str);
        }
        return obj instanceof RequestParameters ? this.f1801a.getFeedBiddingToken((RequestParameters) obj) : this.f1801a.getFeedBiddingToken(null);
    }

    @Override // com.bytedance.msdk.adapter.baidu.base.MediationAdLoaderBaseFunction
    public void realLoader(Context context, MediationAdSlotValueSet mediationAdSlotValueSet) {
        if (context != null) {
            if (mediationAdSlotValueSet.getOriginType() == 1 || mediationAdSlotValueSet.getOriginType() == 2) {
                b(context.getApplicationContext(), mediationAdSlotValueSet);
            } else if (mediationAdSlotValueSet.getOriginType() == 3) {
                a(context.getApplicationContext(), mediationAdSlotValueSet);
            } else {
                notifyAdFailed(80001, "originType 类型不正确");
            }
        }
    }

    @Override // com.bytedance.msdk.adapter.baidu.base.MediationAdLoaderBaseFunction, com.bykv.vk.openvk.api.proto.Bridge
    public ValueSet values() {
        return null;
    }
}
