package com.bytedance.msdk.adapter.baidu;

import android.content.Context;
import android.util.SparseArray;
import com.baidu.mobads.sdk.api.BaiduNativeManager;
import com.baidu.mobads.sdk.api.NativeResponse;
import com.baidu.mobads.sdk.api.RequestParameters;
import com.baidu.mobads.sdk.api.XAdNativeResponse;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import com.bykv.vk.openvk.api.proto.ValueSet;
import com.bytedance.msdk.adapter.baidu.base.config.MediationAdSlotValueSet;
import com.bytedance.msdk.adapter.baidu.base.utils.MediationValueUtil;
import java.util.ArrayList;
import java.util.List;
import java.util.function.Function;

/* JADX INFO: loaded from: classes2.dex */
public class BaiduDrawLoader extends BaiduBaseLoader {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private BaiduDrawExpressAd f1776a;
    private MediationAdSlotValueSet b;
    private BaiduNativeManager c;

    @Override // com.bytedance.msdk.adapter.baidu.base.MediationAdLoaderBaseFunction
    public <T> T callFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
        return i == 8139 ? (T) String.valueOf(getBiddingToken((Context) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveWaitP2pReadyThreshold), Context.class, null), (String) MediationValueUtil.objectValue(sparseArray.get(AVMDLDataLoader.KeyIsLiveCacheThresholdP2pToHttp), String.class, null), MediationValueUtil.objectValue(sparseArray.get(8044), Object.class, null))) : (T) MediationValueUtil.checkClassType(cls);
    }

    public String getBiddingToken(Context context, String str, Object obj) {
        if (this.c == null) {
            this.c = new BaiduNativeManager(context, str);
        }
        return obj instanceof RequestParameters ? this.c.getFeedBiddingToken((RequestParameters) obj) : this.c.getFeedBiddingToken(null);
    }

    @Override // com.bytedance.msdk.adapter.baidu.base.MediationAdLoaderBaseFunction
    public void realLoader(final Context context, MediationAdSlotValueSet mediationAdSlotValueSet) {
        this.b = mediationAdSlotValueSet;
        if (context != null) {
            if (this.c == null) {
                this.c = new BaiduNativeManager(context.getApplicationContext(), mediationAdSlotValueSet.getADNId());
            }
            RequestParameters requestParameters = BaiduAdapterUtil.getRequestParameters(mediationAdSlotValueSet);
            setBiddingResult(getAdnId(), isClientBidding(), requestParameters);
            this.c.loadPortraitVideoAd(requestParameters, new BaiduNativeManager.FeedAdListener() { // from class: com.bytedance.msdk.adapter.baidu.BaiduDrawLoader.1
                @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.FeedAdListener
                public void onLpClosed() {
                }

                public void onNativeFail(int i, String str) {
                    BaiduDrawLoader.this.notifyAdFailed(i, str);
                }

                @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.FeedAdListener
                public void onNativeFail(int i, String str, NativeResponse nativeResponse) {
                    BaiduDrawLoader.this.notifyAdFailed(i, str);
                }

                @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.FeedAdListener
                public void onNativeLoad(List<NativeResponse> list) {
                    if (list == null || list.size() <= 0) {
                        BaiduDrawLoader.this.notifyAdFailed(80001, "加载成功无数据");
                        return;
                    }
                    ArrayList arrayList = new ArrayList();
                    Function<SparseArray<Object>, Object> gMBridge = BaiduDrawLoader.this.getGMBridge();
                    BaiduDrawLoader baiduDrawLoader = BaiduDrawLoader.this;
                    Context applicationContext = context.getApplicationContext();
                    XAdNativeResponse xAdNativeResponse = (XAdNativeResponse) list.get(0);
                    BaiduDrawLoader baiduDrawLoader2 = BaiduDrawLoader.this;
                    baiduDrawLoader.f1776a = new BaiduDrawExpressAd(applicationContext, xAdNativeResponse, baiduDrawLoader2, gMBridge, baiduDrawLoader2.b);
                    arrayList.add(gMBridge);
                    BaiduDrawLoader.this.notifyAdSuccess(arrayList);
                }

                public void onNoAd(int i, String str) {
                    BaiduDrawLoader.this.notifyAdFailed(i, str);
                }

                @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.FeedAdListener
                public void onNoAd(int i, String str, NativeResponse nativeResponse) {
                    BaiduDrawLoader.this.notifyAdFailed(i, str);
                }

                @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.FeedAdListener
                public void onVideoDownloadFailed() {
                }

                @Override // com.baidu.mobads.sdk.api.BaiduNativeManager.FeedAdListener
                public void onVideoDownloadSuccess() {
                }
            });
        }
    }

    @Override // com.bytedance.msdk.adapter.baidu.base.MediationAdLoaderBaseFunction, com.bykv.vk.openvk.api.proto.Bridge
    public ValueSet values() {
        return null;
    }
}
