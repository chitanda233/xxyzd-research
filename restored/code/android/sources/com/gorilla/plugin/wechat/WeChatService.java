package com.gorilla.plugin.wechat;

import android.app.Activity;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.graphics.Bitmap;
import android.net.Uri;
import android.os.Build;
import android.util.Base64;
import com.alipay.sdk.m.c0.d;
import com.baidu.mobads.sdk.internal.a;
import com.byazt.nys.PluginConstants;
import com.gorilla.base.callback.ICancelCallback;
import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import com.gorilla.base.log.ILogger;
import com.gorilla.base.log.LogFactory;
import com.gorilla.base.service.MetaDataService;
import com.gorilla.base.util.GorillaFileProviderUtils;
import com.tencent.mm.opensdk.constants.ConstantsAPI;
import com.tencent.mm.opensdk.modelbase.BaseReq;
import com.tencent.mm.opensdk.modelbase.BaseResp;
import com.tencent.mm.opensdk.modelmsg.SendAuth;
import com.tencent.mm.opensdk.modelmsg.SendMessageToWX;
import com.tencent.mm.opensdk.modelmsg.WXImageObject;
import com.tencent.mm.opensdk.modelmsg.WXMediaMessage;
import com.tencent.mm.opensdk.modelmsg.WXTextObject;
import com.tencent.mm.opensdk.modelmsg.WXWebpageObject;
import com.tencent.mm.opensdk.modelpay.PayReq;
import com.tencent.mm.opensdk.modelpay.PayResp;
import com.tencent.mm.opensdk.openapi.IWXAPI;
import com.tencent.mm.opensdk.openapi.IWXAPIEventHandler;
import com.tencent.mm.opensdk.openapi.WXAPIFactory;
import com.tencent.mm.opensdk.utils.ILog;
import java.io.File;
import java.io.FileOutputStream;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class WeChatService {
    private static final int SHARE_TYPE_IMAGE = 1;
    private static final int SHARE_TYPE_TEXT = 3;
    private static final int SHARE_TYPE_WEBPAGE = 2;
    private static final String State = "none";
    private static final String TAG = "[WeChatService]";
    private static final WeChatService instance = new WeChatService();
    public static ILogger logger;
    private IWXAPI api;
    private String appId;
    private boolean enableDebug;
    private ICancelCallback loginCancelCallback;
    private IFailureCallback loginFailureCallback;
    private ISuccessCallback loginSuccessCallback;
    private ICancelCallback payCancelCallback;
    private IFailureCallback payFailureCallback;
    private ISuccessCallback paySuccessCallback;
    private ICancelCallback shareCancelCallback;
    private IFailureCallback shareFailureCallback;
    private ISuccessCallback shareSuccessCallback;

    public boolean checkAndroidNotBelowN() {
        return true;
    }

    public void onReq(BaseReq baseReq) {
    }

    public static WeChatService getInstance() {
        return instance;
    }

    private WeChatService() {
        logger = LogFactory.getLogger();
        try {
            this.appId = MetaDataService.getMetaData("gorillaWeChatAppId", "");
            this.enableDebug = MetaDataService.getMetaData("gorillaWeChatEnableDebug", false);
        } catch (Exception e) {
            logger.error(TAG, "Failed to get appId: " + e.getMessage());
        }
    }

    public boolean isInstalled() {
        IWXAPI iwxapi = this.api;
        return iwxapi != null && iwxapi.isWXAppInstalled();
    }

    public IWXAPI getApi() {
        return this.api;
    }

    public void login(Activity activity, JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        registerToWX(activity);
        if (!isInstalled()) {
            logger.error(TAG, "WeChat is not installed");
            if (iFailureCallback != null) {
                iFailureCallback.onFailure(-1, "WeChat is not installed");
                return;
            }
            return;
        }
        this.loginSuccessCallback = iSuccessCallback;
        this.loginFailureCallback = iFailureCallback;
        this.loginCancelCallback = iCancelCallback;
        SendAuth.Req req = new SendAuth.Req();
        req.scope = "snsapi_userinfo";
        req.state = "none";
        if (this.api.sendReq(req)) {
            return;
        }
        logger.error(TAG, "Failed to send login request");
    }

    public void share(Activity activity, JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        logger.log(TAG, "share: " + jSONObject);
        registerToWX(activity);
        if (!isInstalled()) {
            logger.error(TAG, "WeChat is not installed");
            if (iFailureCallback != null) {
                iFailureCallback.onFailure(-1, "WeChat is not installed");
                return;
            }
            return;
        }
        this.shareSuccessCallback = iSuccessCallback;
        this.shareFailureCallback = iFailureCallback;
        this.shareCancelCallback = iCancelCallback;
        startShare(activity, jSONObject);
    }

    public void purchase(Activity activity, JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        registerToWX(activity);
        if (!isInstalled()) {
            logger.error(TAG, "WeChat is not installed");
            if (iFailureCallback != null) {
                iFailureCallback.onFailure(-1, "WeChat is not installed");
                return;
            }
            return;
        }
        this.paySuccessCallback = iSuccessCallback;
        this.payFailureCallback = iFailureCallback;
        this.payCancelCallback = iCancelCallback;
        PayReq payReq = new PayReq();
        payReq.appId = this.appId;
        payReq.partnerId = jSONObject.optString("partnerId", "");
        payReq.prepayId = jSONObject.optString("prepayId", "");
        payReq.packageValue = jSONObject.optString("packageValue", "Sign=WXPay");
        payReq.nonceStr = jSONObject.optString("nonceStr", "");
        payReq.timeStamp = jSONObject.optString("timeStamp", "");
        payReq.sign = jSONObject.optString("sign", "");
        if (this.api.sendReq(payReq)) {
            return;
        }
        logger.error(TAG, "Failed to send pay request");
    }

    public boolean handleIntent(Intent intent, IWXAPIEventHandler iWXAPIEventHandler) {
        IWXAPI iwxapi = this.api;
        if (iwxapi != null) {
            return iwxapi.handleIntent(intent, iWXAPIEventHandler);
        }
        return false;
    }

    public void onResp(BaseResp baseResp) {
        try {
            if (baseResp instanceof SendAuth.Resp) {
                processLoginResponse((SendAuth.Resp) baseResp);
            } else if (baseResp instanceof SendMessageToWX.Resp) {
                processShareResponse((SendMessageToWX.Resp) baseResp);
            } else if (baseResp instanceof PayResp) {
                processPayResponse((PayResp) baseResp);
            } else {
                logger.warning(TAG, "Unknown response type: " + baseResp.getType());
            }
        } catch (Exception e) {
            logger.error(TAG, "onResp error: " + e.getMessage());
        }
    }

    private void processLoginResponse(SendAuth.Resp resp) {
        if (resp.errCode == 0) {
            logger.log(TAG, "Login successful, code: " + resp.code);
            try {
                String strBuildLoginResult = buildLoginResult(resp);
                ISuccessCallback iSuccessCallback = this.loginSuccessCallback;
                if (iSuccessCallback != null) {
                    iSuccessCallback.onSuccess(strBuildLoginResult);
                } else {
                    logger.warning(TAG, "Login successful but no callback provided");
                }
                return;
            } catch (Exception e) {
                logger.error(TAG, "processLoginResponse error: " + e.getMessage());
                IFailureCallback iFailureCallback = this.loginFailureCallback;
                if (iFailureCallback != null) {
                    iFailureCallback.onFailure(-1, "processLoginResponse error: " + e.getMessage());
                    return;
                } else {
                    logger.warning(TAG, "Login failed but no callback provided");
                    return;
                }
            }
        }
        if (resp.errCode == -2) {
            logger.warning(TAG, "Login canceled");
            ICancelCallback iCancelCallback = this.loginCancelCallback;
            if (iCancelCallback != null) {
                iCancelCallback.onCancel();
                return;
            } else {
                logger.warning(TAG, "Login canceled but no callback provided");
                return;
            }
        }
        logger.error(TAG, "Login failed, code: " + resp.errCode + ", message: " + resp.errStr);
        IFailureCallback iFailureCallback2 = this.loginFailureCallback;
        if (iFailureCallback2 != null) {
            iFailureCallback2.onFailure(resp.errCode, resp.errStr);
        } else {
            logger.warning(TAG, "Login failed but no callback provided");
        }
    }

    private String buildLoginResult(SendAuth.Resp resp) throws Exception {
        JSONObject jSONObject = new JSONObject();
        jSONObject.put(PluginConstants.KEY_ERROR_CODE, resp.code);
        jSONObject.put("state", resp.state);
        jSONObject.put("lang", resp.lang);
        jSONObject.put("country", resp.country);
        return jSONObject.toString();
    }

    public void registerToWX(Activity activity) {
        if (this.api != null) {
            return;
        }
        String str = this.appId;
        if (str == null || str.isEmpty()) {
            logger.error(TAG, "appId is empty");
            return;
        }
        if (activity == null) {
            logger.error(TAG, "Activity is null");
            return;
        }
        logger.log(TAG, "Registering to WeChat with: " + this.appId);
        IWXAPI iwxapiCreateWXAPI = WXAPIFactory.createWXAPI(activity, this.appId);
        this.api = iwxapiCreateWXAPI;
        if (this.enableDebug) {
            iwxapiCreateWXAPI.setLogImpl(new WeChatSDKLog());
        }
        if (!this.api.registerApp(this.appId)) {
            logger.error(TAG, "Failed to register to WeChat");
        }
        if (Build.VERSION.SDK_INT >= 34) {
            activity.registerReceiver(new BroadcastReceiver() { // from class: com.gorilla.plugin.wechat.WeChatService.1
                @Override // android.content.BroadcastReceiver
                public void onReceive(Context context, Intent intent) {
                    WeChatService.logger.log(WeChatService.TAG, "on received WeChat broadcast");
                    WeChatService.this.api.registerApp(WeChatService.this.appId);
                }
            }, new IntentFilter(ConstantsAPI.ACTION_REFRESH_WXAPP), 2);
        } else {
            activity.registerReceiver(new BroadcastReceiver() { // from class: com.gorilla.plugin.wechat.WeChatService.2
                @Override // android.content.BroadcastReceiver
                public void onReceive(Context context, Intent intent) {
                    WeChatService.logger.log(WeChatService.TAG, "on received WeChat broadcast");
                    WeChatService.this.api.registerApp(WeChatService.this.appId);
                }
            }, new IntentFilter(ConstantsAPI.ACTION_REFRESH_WXAPP));
        }
    }

    private void startShare(Activity activity, JSONObject jSONObject) {
        ShareData shareData = new ShareData(jSONObject);
        int i = shareData.shareType;
        if (i == 1) {
            shareImage(activity, shareData);
            return;
        }
        if (i == 2) {
            shareWebPage(activity, shareData);
            return;
        }
        if (i == 3) {
            shareText(activity, shareData);
            return;
        }
        logger.error(TAG, "Unknown share type: " + shareData.shareType);
        IFailureCallback iFailureCallback = this.shareFailureCallback;
        if (iFailureCallback != null) {
            iFailureCallback.onFailure(-1, "Unknown share type: " + shareData.shareType);
        }
    }

    private void processPayResponse(PayResp payResp) {
        String string;
        if (payResp.errCode == 0) {
            logger.log(TAG, "Pay successful");
            if (this.paySuccessCallback == null) {
                logger.warning(TAG, "Pay successful but no callback provided");
                return;
            }
            try {
                JSONObject jSONObject = new JSONObject();
                jSONObject.put("returnKey", payResp.returnKey);
                jSONObject.put("transaction", payResp.transaction);
                jSONObject.put("prepayId", payResp.prepayId);
                jSONObject.put("extData", payResp.extData);
                string = jSONObject.toString();
            } catch (JSONException e) {
                logger.error(TAG, "processPayResponse error: " + e.getMessage());
                IFailureCallback iFailureCallback = this.payFailureCallback;
                if (iFailureCallback != null) {
                    iFailureCallback.onFailure(-1, "processPayResponse error: " + e.getMessage());
                }
                string = null;
            }
            if (string != null) {
                this.paySuccessCallback.onSuccess(string);
                return;
            }
            return;
        }
        if (payResp.errCode == -2) {
            logger.warning(TAG, "Pay canceled");
            ICancelCallback iCancelCallback = this.payCancelCallback;
            if (iCancelCallback != null) {
                iCancelCallback.onCancel();
                return;
            } else {
                logger.warning(TAG, "Pay canceled but no callback provided");
                return;
            }
        }
        logger.error(TAG, "Pay failed, code: " + payResp.errCode + ", message: " + payResp.errStr);
        IFailureCallback iFailureCallback2 = this.payFailureCallback;
        if (iFailureCallback2 != null) {
            iFailureCallback2.onFailure(payResp.errCode, payResp.errStr);
        } else {
            logger.warning(TAG, "Pay failed but no callback provided");
        }
    }

    private void processShareResponse(SendMessageToWX.Resp resp) {
        if (resp.errCode == 0) {
            logger.log(TAG, "Share successful");
            ISuccessCallback iSuccessCallback = this.shareSuccessCallback;
            if (iSuccessCallback != null) {
                iSuccessCallback.onSuccess("Share successful");
                return;
            } else {
                logger.warning(TAG, "Share successful but no callback provided");
                return;
            }
        }
        if (resp.errCode == -2) {
            logger.warning(TAG, "Share canceled");
            ICancelCallback iCancelCallback = this.shareCancelCallback;
            if (iCancelCallback != null) {
                iCancelCallback.onCancel();
                return;
            } else {
                logger.warning(TAG, "Share canceled but no callback provided");
                return;
            }
        }
        logger.error(TAG, "Share failed, code: " + resp.errCode + ", message: " + resp.errStr);
        IFailureCallback iFailureCallback = this.shareFailureCallback;
        if (iFailureCallback != null) {
            iFailureCallback.onFailure(resp.errCode, resp.errStr);
        } else {
            logger.warning(TAG, "Share failed but no callback provided");
        }
    }

    private void shareWebPage(Activity activity, ShareData shareData) {
        if (shareData.webpageUrl == null || shareData.webpageUrl.isEmpty()) {
            IFailureCallback iFailureCallback = this.shareFailureCallback;
            if (iFailureCallback != null) {
                iFailureCallback.onFailure(-1, "Missing webpageUrl for WeChat web page share");
                return;
            }
            return;
        }
        WXWebpageObject wXWebpageObject = new WXWebpageObject();
        wXWebpageObject.webpageUrl = shareData.webpageUrl;
        WXMediaMessage wXMediaMessage = new WXMediaMessage(wXWebpageObject);
        wXMediaMessage.title = shareData.title;
        wXMediaMessage.description = shareData.description;
        wXMediaMessage.thumbData = shareData.getThumbImageBytes();
        SendMessageToWX.Req req = new SendMessageToWX.Req();
        req.transaction = buildTransaction("webpage");
        req.message = wXMediaMessage;
        req.scene = shareData.scene;
        IWXAPI iwxapi = this.api;
        if (iwxapi == null) {
            logger.error(TAG, "WeChat API is not initialized");
            IFailureCallback iFailureCallback2 = this.shareFailureCallback;
            if (iFailureCallback2 != null) {
                iFailureCallback2.onFailure(-1, "WeChat API is not initialized");
                return;
            }
            return;
        }
        if (iwxapi.sendReq(req)) {
            return;
        }
        logger.error(TAG, "shareWebPage failed");
        IFailureCallback iFailureCallback3 = this.shareFailureCallback;
        if (iFailureCallback3 != null) {
            iFailureCallback3.onFailure(-1, "shareWebPage failed");
        }
    }

    private void shareImage(Activity activity, ShareData shareData) {
        String imagePath;
        WXImageObject wXImageObject = new WXImageObject();
        byte[] imageBytes = shareData.getImageBytes();
        boolean z = false;
        if (checkVersionValid() && checkAndroidNotBelowN() && (imagePath = shareData.getImagePath(activity)) != null) {
            logger.log(TAG, "share image via FileProvider: " + imagePath);
            wXImageObject = new WXImageObject();
            wXImageObject.setImagePath(imagePath);
            z = true;
        } else {
            wXImageObject.imageData = imageBytes;
        }
        if (!z && (wXImageObject.imageData == null || wXImageObject.imageData.length == 0)) {
            IFailureCallback iFailureCallback = this.shareFailureCallback;
            if (iFailureCallback != null) {
                iFailureCallback.onFailure(-1, "Missing or invalid image data for WeChat image share");
                return;
            }
            return;
        }
        WXMediaMessage wXMediaMessage = new WXMediaMessage();
        wXMediaMessage.mediaObject = wXImageObject;
        wXMediaMessage.thumbData = shareData.getThumbImageBytes();
        wXMediaMessage.title = shareData.title;
        SendMessageToWX.Req req = new SendMessageToWX.Req();
        req.transaction = buildTransaction("image");
        req.message = wXMediaMessage;
        req.scene = shareData.scene;
        IWXAPI iwxapi = this.api;
        if (iwxapi == null) {
            logger.error(TAG, "WeChat API is not initialized");
            IFailureCallback iFailureCallback2 = this.shareFailureCallback;
            if (iFailureCallback2 != null) {
                iFailureCallback2.onFailure(-1, "WeChat API is not initialized");
                return;
            }
            return;
        }
        if (iwxapi.sendReq(req)) {
            return;
        }
        logger.error(TAG, "shareImage failed");
        IFailureCallback iFailureCallback3 = this.shareFailureCallback;
        if (iFailureCallback3 != null) {
            iFailureCallback3.onFailure(-1, "shareImage failed");
        }
    }

    private void shareText(Activity activity, ShareData shareData) {
        String textContent = shareData.getTextContent();
        if (textContent == null || textContent.isEmpty()) {
            IFailureCallback iFailureCallback = this.shareFailureCallback;
            if (iFailureCallback != null) {
                iFailureCallback.onFailure(-1, "Missing text for WeChat text share");
                return;
            }
            return;
        }
        WXTextObject wXTextObject = new WXTextObject();
        wXTextObject.text = textContent;
        WXMediaMessage wXMediaMessage = new WXMediaMessage();
        wXMediaMessage.mediaObject = wXTextObject;
        wXMediaMessage.description = shareData.description;
        SendMessageToWX.Req req = new SendMessageToWX.Req();
        req.transaction = buildTransaction(a.b);
        req.message = wXMediaMessage;
        req.scene = shareData.scene;
        IWXAPI iwxapi = this.api;
        if (iwxapi == null) {
            logger.error(TAG, "WeChat API is not initialized");
            IFailureCallback iFailureCallback2 = this.shareFailureCallback;
            if (iFailureCallback2 != null) {
                iFailureCallback2.onFailure(-1, "WeChat API is not initialized");
                return;
            }
            return;
        }
        if (iwxapi.sendReq(req)) {
            return;
        }
        logger.error(TAG, "shareText failed");
        IFailureCallback iFailureCallback3 = this.shareFailureCallback;
        if (iFailureCallback3 != null) {
            iFailureCallback3.onFailure(-1, "shareText failed");
        }
    }

    private static String buildTransaction(String str) {
        return str == null ? String.valueOf(System.currentTimeMillis()) : str + System.currentTimeMillis();
    }

    private boolean checkVersionValid() {
        IWXAPI iwxapi = this.api;
        return iwxapi != null && iwxapi.getWXAppSupportAPI() >= 654314752;
    }

    private static class ShareData {
        private static final int MAX_IMAGE_BYTES = 1048576;
        private static final int MAX_THUMB_BYTES = 65536;
        public String description;
        public String image;
        public int scene;
        public int shareType;
        public String text;
        public String thumbImage;
        public String title;
        public String webpageUrl;

        public ShareData(JSONObject jSONObject) {
            this.scene = -1;
            try {
                this.shareType = parseInteger(jSONObject.opt("shareType"), -1);
                this.title = jSONObject.optString(d.w);
                this.description = jSONObject.optString("description");
                this.image = jSONObject.optString("image");
                this.thumbImage = jSONObject.optString("thumbImage");
                int integer = parseInteger(jSONObject.opt("scene"), 0);
                this.scene = integer;
                if (integer < 0) {
                    this.scene = 0;
                }
                String strOptString = jSONObject.optString("webpageUrl");
                this.webpageUrl = strOptString;
                if (strOptString == null || strOptString.isEmpty()) {
                    this.webpageUrl = jSONObject.optString("url");
                }
                this.text = jSONObject.optString(a.b);
            } catch (Exception e) {
                WeChatService.logger.error(WeChatService.TAG, "error parse share args: " + jSONObject + ", error: " + e.getMessage());
            }
        }

        public String getTextContent() {
            String str = this.text;
            if (str != null && !str.isEmpty()) {
                return this.text;
            }
            return this.title;
        }

        private int parseInteger(Object obj, int i) {
            if (obj == null) {
                return i;
            }
            if (obj instanceof Number) {
                return ((Number) obj).intValue();
            }
            if (obj instanceof String) {
                String str = (String) obj;
                if (str.isEmpty()) {
                    return i;
                }
                try {
                    return Integer.parseInt(str);
                } catch (Exception unused) {
                }
            }
            return i;
        }

        public byte[] getImageBytes() {
            return loadAndFit(this.image, 1048576, Bitmap.CompressFormat.JPEG);
        }

        public byte[] getThumbImageBytes() {
            return loadAndFit(this.thumbImage, 65536, Bitmap.CompressFormat.JPEG);
        }

        public String getImagePath(Activity activity) {
            try {
                File file = new File(activity.getExternalFilesDir(null), "shareData");
                if (!file.exists()) {
                    WeChatService.logger.log(WeChatService.TAG, "create shareData dir: " + file.getAbsolutePath());
                    file.mkdir();
                }
                File file2 = new File(file, "share_" + System.currentTimeMillis() + ".jpg");
                FileOutputStream fileOutputStream = new FileOutputStream(file2);
                fileOutputStream.write(Base64.decode(this.image, 0));
                fileOutputStream.close();
                WeChatService.logger.log(WeChatService.TAG, "create share image file: " + file2.getAbsolutePath());
                Uri uriForFile = GorillaFileProviderUtils.getUriForFile(activity, file2);
                if (uriForFile == null) {
                    WeChatService.logger.error(WeChatService.TAG, "create share image file error: FileProvider uri is null");
                    return null;
                }
                GorillaFileProviderUtils.grantReadUriPermission(activity, "com.tencent.mm", uriForFile);
                return uriForFile.toString();
            } catch (Exception e) {
                WeChatService.logger.error(WeChatService.TAG, "create share image file error: " + e.getMessage());
                return null;
            }
        }

        /*  JADX ERROR: Type inference failed
            jadx.core.utils.exceptions.JadxOverflowException: Type inference error: updates count limit reached with updateSeq = 2791. Try increasing type updates limit count.
            	at jadx.core.utils.ErrorsCounter.addError(ErrorsCounter.java:59)
            	at jadx.core.utils.ErrorsCounter.error(ErrorsCounter.java:31)
            	at jadx.core.dex.attributes.nodes.NotificationAttrNode.addError(NotificationAttrNode.java:19)
            	at jadx.core.dex.visitors.typeinference.TypeInferenceVisitor.visit(TypeInferenceVisitor.java:79)
            */
        private byte[] loadAndFit(java.lang.String r9, int r10, android.graphics.Bitmap.CompressFormat r11) {
            /*
                Method dump skipped, instruction units count: 279
                To view this dump add '--comments-level debug' option
            */
            throw new UnsupportedOperationException("Method not decompiled: com.gorilla.plugin.wechat.WeChatService.ShareData.loadAndFit(java.lang.String, int, android.graphics.Bitmap$CompressFormat):byte[]");
        }
    }

    private static class WeChatSDKLog implements ILog {
        private WeChatSDKLog() {
        }

        @Override // com.tencent.mm.opensdk.utils.ILog
        public void v(String str, String str2) {
            WeChatService.logger.log("[WeChatLog]", str + ": " + str2);
        }

        @Override // com.tencent.mm.opensdk.utils.ILog
        public void d(String str, String str2) {
            WeChatService.logger.log("[WeChatLog]", str + ": " + str2);
        }

        @Override // com.tencent.mm.opensdk.utils.ILog
        public void i(String str, String str2) {
            WeChatService.logger.log("[WeChatLog]", str + ": " + str2);
        }

        @Override // com.tencent.mm.opensdk.utils.ILog
        public void w(String str, String str2) {
            WeChatService.logger.warning("[WeChatLog]", str + ": " + str2);
        }

        @Override // com.tencent.mm.opensdk.utils.ILog
        public void e(String str, String str2) {
            WeChatService.logger.error("[WeChatLog]", str + ": " + str2);
        }
    }
}
