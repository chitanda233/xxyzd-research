package com.alipay.sdk.m.l;

import com.baidu.oauth.sdkbqt.result.OauthResult;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import com.kwad.library.solder.lib.ext.PluginError;

/* JADX INFO: loaded from: classes.dex */
public enum c {
    SUCCEEDED(9000, "处理成功"),
    FAILED(4000, "系统繁忙，请稍后再试"),
    CANCELED(PluginError.ERROR_BUILD_REMOTE_PLUGIN_INFO, OauthResult.RESULT_MSG_USER_CANCEL),
    NETWORK_ERROR(6002, "网络连接异常"),
    ACTIVITY_NOT_START_EXIT(6007, "支付未完成"),
    PARAMS_ERROR(4001, OauthResult.RESULT_MSG_PARAMS_INVALID),
    DOUBLE_REQUEST(5000, "重复请求"),
    PAY_WAITTING(AVMDLDataLoader.KeyIsLiveSetLoaderType, "支付结果确认中");


    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f308a;
    public String b;

    c(int i, String str) {
        this.f308a = i;
        this.b = str;
    }

    public void b(int i) {
        this.f308a = i;
    }

    public int c() {
        return this.f308a;
    }

    public void a(String str) {
        this.b = str;
    }

    public String b() {
        return this.b;
    }

    public static c a(int i) {
        if (i == 4001) {
            return PARAMS_ERROR;
        }
        if (i == 5000) {
            return DOUBLE_REQUEST;
        }
        if (i == 8000) {
            return PAY_WAITTING;
        }
        if (i == 9000) {
            return SUCCEEDED;
        }
        if (i == 6001) {
            return CANCELED;
        }
        if (i != 6002) {
            return FAILED;
        }
        return NETWORK_ERROR;
    }
}
