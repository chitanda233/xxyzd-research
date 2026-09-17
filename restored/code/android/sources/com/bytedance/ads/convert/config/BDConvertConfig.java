package com.bytedance.ads.convert.config;

import com.bytedance.ads.convert.callback.BDConvertLifecycleCallback;
import com.bytedance.ads.convert.depend.CustomAndroidIDCallback;
import com.bytedance.ads.convert.depend.CustomOaidCallback;
import kotlin.Metadata;

/* JADX INFO: loaded from: classes2.dex */
@Metadata(bv = {1, 0, 3}, d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0018\u0002\n\u0002\b\u000f\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b*\u0010+R\"\u0010\u0003\u001a\u00020\u00028\u0006@\u0006X\u0086\u000e¢\u0006\u0012\n\u0004\b\u0003\u0010\u0004\u001a\u0004\b\u0005\u0010\u0006\"\u0004\b\u0007\u0010\bR$\u0010\n\u001a\u0004\u0018\u00010\t8\u0006@\u0006X\u0086\u000e¢\u0006\u0012\n\u0004\b\n\u0010\u000b\u001a\u0004\b\f\u0010\r\"\u0004\b\u000e\u0010\u000fR\"\u0010\u0010\u001a\u00020\u00028\u0006@\u0006X\u0086\u000e¢\u0006\u0012\n\u0004\b\u0010\u0010\u0004\u001a\u0004\b\u0011\u0010\u0006\"\u0004\b\u0012\u0010\bR$\u0010\u0014\u001a\u0004\u0018\u00010\u00138\u0006@\u0006X\u0086\u000e¢\u0006\u0012\n\u0004\b\u0014\u0010\u0015\u001a\u0004\b\u0016\u0010\u0017\"\u0004\b\u0018\u0010\u0019R\"\u0010\u001a\u001a\u00020\u00028\u0006@\u0006X\u0086\u000e¢\u0006\u0012\n\u0004\b\u001a\u0010\u0004\u001a\u0004\b\u001b\u0010\u0006\"\u0004\b\u001c\u0010\bR$\u0010\u001e\u001a\u0004\u0018\u00010\u001d8\u0006@\u0006X\u0086\u000e¢\u0006\u0012\n\u0004\b\u001e\u0010\u001f\u001a\u0004\b \u0010!\"\u0004\b\"\u0010#R\"\u0010$\u001a\u00020\u00028\u0006@\u0006X\u0086\u000e¢\u0006\u0012\n\u0004\b$\u0010\u0004\u001a\u0004\b%\u0010\u0006\"\u0004\b&\u0010\bR\"\u0010'\u001a\u00020\u00028\u0006@\u0006X\u0086\u000e¢\u0006\u0012\n\u0004\b'\u0010\u0004\u001a\u0004\b(\u0010\u0006\"\u0004\b)\u0010\b¨\u0006,"}, d2 = {"Lcom/bytedance/ads/convert/config/BDConvertConfig;", "", "", "enableLog", "Z", "getEnableLog", "()Z", "setEnableLog", "(Z)V", "Lcom/bytedance/ads/convert/callback/BDConvertLifecycleCallback;", "lifecycleCallback", "Lcom/bytedance/ads/convert/callback/BDConvertLifecycleCallback;", "getLifecycleCallback", "()Lcom/bytedance/ads/convert/callback/BDConvertLifecycleCallback;", "setLifecycleCallback", "(Lcom/bytedance/ads/convert/callback/BDConvertLifecycleCallback;)V", "playSessionEnable", "getPlaySessionEnable", "setPlaySessionEnable", "Lcom/bytedance/ads/convert/depend/CustomAndroidIDCallback;", "customAndroidIDCallback", "Lcom/bytedance/ads/convert/depend/CustomAndroidIDCallback;", "getCustomAndroidIDCallback", "()Lcom/bytedance/ads/convert/depend/CustomAndroidIDCallback;", "setCustomAndroidIDCallback", "(Lcom/bytedance/ads/convert/depend/CustomAndroidIDCallback;)V", "enableIPFetch", "getEnableIPFetch", "setEnableIPFetch", "Lcom/bytedance/ads/convert/depend/CustomOaidCallback;", "customOaidCallback", "Lcom/bytedance/ads/convert/depend/CustomOaidCallback;", "getCustomOaidCallback", "()Lcom/bytedance/ads/convert/depend/CustomOaidCallback;", "setCustomOaidCallback", "(Lcom/bytedance/ads/convert/depend/CustomOaidCallback;)V", "enableOAID", "getEnableOAID", "setEnableOAID", "autoSendLaunchEvent", "getAutoSendLaunchEvent", "setAutoSendLaunchEvent", "<init>", "()V", "convert_release"}, k = 1, mv = {1, 4, 0})
public final class BDConvertConfig {
    private CustomAndroidIDCallback customAndroidIDCallback;
    private CustomOaidCallback customOaidCallback;
    private boolean enableIPFetch;
    private boolean enableLog;
    private BDConvertLifecycleCallback lifecycleCallback;
    private boolean autoSendLaunchEvent = true;
    private boolean playSessionEnable = true;
    private boolean enableOAID = true;

    public final boolean getAutoSendLaunchEvent() {
        return this.autoSendLaunchEvent;
    }

    public final CustomAndroidIDCallback getCustomAndroidIDCallback() {
        return this.customAndroidIDCallback;
    }

    public final CustomOaidCallback getCustomOaidCallback() {
        return this.customOaidCallback;
    }

    public final boolean getEnableIPFetch() {
        return this.enableIPFetch;
    }

    public final boolean getEnableLog() {
        return this.enableLog;
    }

    public final boolean getEnableOAID() {
        return this.enableOAID;
    }

    public final BDConvertLifecycleCallback getLifecycleCallback() {
        return this.lifecycleCallback;
    }

    public final boolean getPlaySessionEnable() {
        return this.playSessionEnable;
    }

    public final void setAutoSendLaunchEvent(boolean z) {
        this.autoSendLaunchEvent = z;
    }

    public final void setCustomAndroidIDCallback(CustomAndroidIDCallback customAndroidIDCallback) {
        this.customAndroidIDCallback = customAndroidIDCallback;
    }

    public final void setCustomOaidCallback(CustomOaidCallback customOaidCallback) {
        this.customOaidCallback = customOaidCallback;
    }

    public final void setEnableIPFetch(boolean z) {
        this.enableIPFetch = z;
    }

    public final void setEnableLog(boolean z) {
        this.enableLog = z;
    }

    public final void setEnableOAID(boolean z) {
        this.enableOAID = z;
    }

    public final void setLifecycleCallback(BDConvertLifecycleCallback bDConvertLifecycleCallback) {
        this.lifecycleCallback = bDConvertLifecycleCallback;
    }

    public final void setPlaySessionEnable(boolean z) {
        this.playSessionEnable = z;
    }
}
