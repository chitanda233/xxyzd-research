package com.kwad.sdk;

import android.content.Context;
import android.util.Log;
import com.kwad.components.offline.api.BuildConfig;
import com.kwad.sdk.api.KsLoadManager;
import com.kwad.sdk.api.SdkConfig;
import com.kwad.sdk.api.core.IKsAdSDK;
import com.kwad.sdk.api.core.KsAdSdkDynamicImpl;
import com.kwad.sdk.api.proxy.IComponentProxy;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
@KsAdSdkDynamicImpl(IKsAdSDK.class)
public class KsAdSDKImpl implements IKsAdSDK {
    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void reportBatchEvent(int i, Map<String, Object> map) {
    }

    private KsAdSDKImpl() {
    }

    static class a {
        private static final KsAdSDKImpl aGg = new KsAdSDKImpl();
    }

    @KsAdSdkDynamicImpl(IKsAdSDK.class)
    public static KsAdSDKImpl get() {
        return a.aGg;
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public synchronized void init(Context context, SdkConfig sdkConfig) {
        Log.w("jky", "KsAdSDKImpl init call start");
        o oVarGE = o.GE();
        oVarGE.b(context, sdkConfig);
        if (!oVarGE.GH()) {
            oVarGE.GF();
        }
        Log.w("jky", "KsAdSDKImpl init call end");
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public synchronized void start() {
        Log.e("jky", "KsAdSDKImpl start call 1");
        o oVarGE = o.GE();
        Log.e("jky", "KsAdSDKImpl start call 2");
        if (oVarGE.GH()) {
            Log.e("jky", "KsAdSDKImpl start call 3");
            oVarGE.GF();
            Log.e("jky", "KsAdSDKImpl start call 4");
        }
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public boolean isDebugLogEnable() {
        o.GE();
        return o.isDebugLogEnable();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public String getAppId() {
        o.GE();
        return o.getAppId();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public String getAppName() {
        o.GE();
        return o.getAppName();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public Context getContext() {
        o.GE();
        return o.getContext();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public KsLoadManager getAdManager() {
        return o.GE().getAdManager();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void unInit() {
        o.GE().unInit();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public String getSDKVersion() {
        o.GE();
        return o.getSDKVersion();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public int getSDKVersionCode() {
        o.GE();
        return BuildConfig.VERSION_CODE;
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public int getSDKType() {
        o.GE();
        return 1;
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public String getApiVersion() {
        return o.GE().getApiVersion();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public int getApiVersionCode() {
        return o.GE().getApiVersionCode();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void setApiVersion(String str) {
        o.GE().setApiVersion(str);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void setApiVersionCode(int i) {
        o.GE().setApiVersionCode(i);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void deleteCache() {
        o.GE();
        o.deleteCache();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public <T extends IComponentProxy> T newComponentProxy(Class<?> cls, Object obj) {
        return (T) o.GE().newComponentProxy(cls, obj);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public <T> T newInstance(Class<T> cls) {
        o.GE();
        return (T) o.newInstance(cls);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public JSONObject getAppInfo() {
        o.GE();
        return o.getAppInfo();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public JSONObject getDeviceInfo() {
        o.GE();
        return o.getDeviceInfo();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public JSONObject getNetworkInfo() {
        o.GE();
        return o.getNetworkInfo();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void setIsExternal(boolean z) {
        o.GE().setIsExternal(z);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public String getDid() {
        o.GE();
        return o.getDid();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void resumeCurrentPlayer() {
        o.GE();
        o.resumeCurrentPlayer();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void pauseCurrentPlayer() {
        o.GE();
        o.pauseCurrentPlayer();
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void setPersonalRecommend(boolean z) {
        o.GE().setPersonalRecommend(z);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void setProgrammaticRecommend(boolean z) {
        o.GE().setProgrammaticRecommend(z);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void setAdxEnable(boolean z) {
        o.GE().setAdxEnable(z);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void setAppTag(String str) {
        o.GE().setAppTag(str);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void setLaunchTime(long j) {
        o.GE().setLaunchTime(j);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void setInitStartTime(long j) {
        o.GE().setInitStartTime(j);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void setThemeMode(int i) {
        o.GE();
        o.setThemeMode(i);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void setLoadingLottieAnimation(boolean z, int i) {
        o.GE();
        o.setLoadingLottieAnimation(z, i);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void setLoadingLottieAnimationColor(boolean z, int i) {
        o.GE();
        o.setLoadingLottieAnimationColor(z, i);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void re(Object obj) {
        if (obj instanceof Throwable) {
            o.GE();
            o.r((Throwable) obj);
        }
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void addHp(Map<String, String> map) {
        o.GE();
        o.f(map);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public String getRM(String str) {
        o.GE();
        return o.cR(str);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public String getRD(String str) {
        o.GE();
        return o.cS(str);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public void sR(String str, Map<String, String> map, String str2) {
        o.GE();
        o.b(str, map, str2);
    }

    @Override // com.kwad.sdk.api.core.IKsAdSDK
    public Object dM(String str, Object... objArr) {
        o.GE();
        return o.f(str, objArr);
    }

    public SdkConfig getSdkConfig() {
        o.GE();
        return o.getSdkConfig();
    }
}
