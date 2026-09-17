package com.sigmob.sdk.base.common;

import android.content.Context;
import android.net.Uri;
import com.czhj.sdk.common.utils.AppPackageUtil;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.sdk.logger.SigmobLogger;
import com.czhj.wire.Wire;
import com.sigmob.sdk.base.BaseAdActivity;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.rtb.AndroidMarket;
import com.sigmob.sdk.base.models.rtb.WXProgramRes;

/* JADX INFO: loaded from: classes3.dex */
public enum an {
    IGNORE_ABOUT_SCHEME(0 == true ? 1 : 0) { // from class: com.sigmob.sdk.base.common.an.1
        @Override // com.sigmob.sdk.base.common.an
        public String a(BaseAdUnit adUnit) {
            return null;
        }

        @Override // com.sigmob.sdk.base.common.an
        protected void a(Context context, Uri uri, ao urlHandler, BaseAdUnit adUnit) {
            an.b(this, "performAction", adUnit, null);
            SigmobLog.d("Link to about page ignored.");
        }

        @Override // com.sigmob.sdk.base.common.an
        public boolean a(Uri uri, int interActionType) {
            return "about".equalsIgnoreCase(uri.getScheme());
        }
    },
    MINI_PROGRAM(0 == true ? 1 : 0) { // from class: com.sigmob.sdk.base.common.an.2
        @Override // com.sigmob.sdk.base.common.an
        public String a(BaseAdUnit adUnit) {
            WXProgramRes wXProgramRes;
            if (adUnit == null || (wXProgramRes = adUnit.getWXProgramRes()) == null) {
                return null;
            }
            return wXProgramRes.wx_app_id;
        }

        @Override // com.sigmob.sdk.base.common.an
        protected void a(Context context, Uri uri, ao urlHandler, BaseAdUnit adUnit) throws Exception {
            an.b(this, "performAction", adUnit, null);
            int interactionType = adUnit.getInteractionType();
            if (interactionType != 7) {
                String str = "performAction interaction_type is not right with " + interactionType;
                an.b(this, "performAction", adUnit, str);
                throw new Exception(str);
            }
            WXProgramRes wXProgramRes = adUnit.getWXProgramRes();
            if (wXProgramRes == null) {
                return;
            }
            com.sigmob.sdk.base.utils.h.a(com.sigmob.sdk.b.e(), wXProgramRes.wx_app_id, wXProgramRes.wx_app_username, wXProgramRes.wx_app_path, wXProgramRes.wx_business_type.intValue(), wXProgramRes.wx_ext_msg);
        }

        @Override // com.sigmob.sdk.base.common.an
        public boolean a(final Uri uri, int interActionType) {
            String scheme = uri.getScheme();
            return ("HTTP".equalsIgnoreCase(scheme) || "HTTPS".equalsIgnoreCase(scheme) || interActionType != 7) ? false : true;
        }
    },
    FOLLOW_DEEP_LINK(1 == true ? 1 : 0) { // from class: com.sigmob.sdk.base.common.an.3
        @Override // com.sigmob.sdk.base.common.an
        public String a(BaseAdUnit adUnit) {
            if (adUnit == null) {
                return null;
            }
            return adUnit.getDeeplinkUrl();
        }

        @Override // com.sigmob.sdk.base.common.an
        protected void a(Context context, Uri uri, ao urlHandler, BaseAdUnit adUnit) throws Exception {
            an.b(this, "performAction", adUnit, null);
            try {
                int interactionType = adUnit.getInteractionType();
                h.d(adUnit);
                adUnit.setDeeplinkUri(uri);
                String host = uri.getHost();
                if (interactionType != 8 && (!com.sigmob.sdk.base.utils.s.b(host) || !host.equalsIgnoreCase("hapjs.org"))) {
                    com.sigmob.sdk.base.utils.h.a(context, uri, com.sigmob.sdk.base.utils.h.a(context, uri, adUnit.getMarketPackageNameList()), adUnit.enableSmallWindow(Integer.valueOf(interactionType)));
                    return;
                }
                com.sigmob.sdk.base.utils.h.a(context, uri, com.sigmob.sdk.b.a());
            } catch (Exception e) {
                h.d((BaseAdUnit) null);
                adUnit.setDeeplinkUri(null);
                throw e;
            }
        }

        @Override // com.sigmob.sdk.base.common.an
        public boolean a(Uri uri, int interActionType) {
            String scheme = uri.getScheme();
            String host = uri.getHost();
            if (interActionType == 8 || (com.sigmob.sdk.base.utils.s.b(host) && host.equalsIgnoreCase("hapjs.org"))) {
                return "HTTP".equalsIgnoreCase(scheme) || "HTTPS".equalsIgnoreCase(scheme) || "HAP".equalsIgnoreCase(scheme);
            }
            return ("HTTP".equalsIgnoreCase(scheme) || "HTTPS".equalsIgnoreCase(scheme)) ? false : true;
        }
    },
    FOLLOW_PACKAGE_NAME(1 == true ? 1 : 0) { // from class: com.sigmob.sdk.base.common.an.4
        @Override // com.sigmob.sdk.base.common.an
        public String a(BaseAdUnit adUnit) {
            if (adUnit == null) {
                return null;
            }
            return com.sigmob.sdk.base.utils.s.a((CharSequence) adUnit.getApkPackageName()) ? adUnit.getProductId() : adUnit.getApkPackageName();
        }

        @Override // com.sigmob.sdk.base.common.an
        protected void a(Context context, Uri uri, ao urlHandler, BaseAdUnit adUnit) throws Exception {
            an.b(this, "performAction", adUnit, null);
            String apkPackageName = adUnit.getApkPackageName();
            if (adUnit.getsubInteractionType() == 2 || com.sigmob.sdk.base.utils.s.b(apkPackageName)) {
                if (!com.sigmob.sdk.base.utils.s.b(apkPackageName)) {
                    apkPackageName = adUnit.getProductId();
                }
                if (com.sigmob.sdk.base.utils.s.b(apkPackageName)) {
                    boolean zA = com.sigmob.sdk.base.utils.v.a(adUnit.enableSmallWindow());
                    try {
                        h.c(adUnit);
                        com.sigmob.sdk.base.utils.h.a(context, (Uri) null, apkPackageName, zA);
                        return;
                    } catch (Throwable th) {
                        an.b(this, "performAction", adUnit, th.getMessage());
                        h.c((BaseAdUnit) null);
                    }
                }
            }
            throw new Exception("can't launch application for packageName " + adUnit.getProductId());
        }

        @Override // com.sigmob.sdk.base.common.an
        public boolean a(Uri uri, int interActionType) {
            return interActionType == 2;
        }
    },
    MARKET_SCHEME(0 == true ? 1 : 0) { // from class: com.sigmob.sdk.base.common.an.5
        @Override // com.sigmob.sdk.base.common.an
        public String a(BaseAdUnit adUnit) {
            AndroidMarket androidMarket;
            if (adUnit == null || (androidMarket = adUnit.getAndroidMarket()) == null) {
                return null;
            }
            return androidMarket.market_url;
        }

        @Override // com.sigmob.sdk.base.common.an
        protected void a(Context context, Uri uri, ao urlHandler, BaseAdUnit adUnit) throws Exception {
            String strA = null;
            an.b(this, "performAction", adUnit, null);
            AndroidMarket androidMarket = adUnit.getAndroidMarket();
            if (androidMarket == null) {
                return;
            }
            int iIntValue = ((Integer) Wire.get(androidMarket.type, 0)).intValue();
            if (com.sigmob.sdk.base.utils.s.b(androidMarket.appstore_package_name)) {
                try {
                    if (AppPackageUtil.getPackageVersionCode(context, androidMarket.appstore_package_name) != -1) {
                        strA = androidMarket.appstore_package_name;
                    }
                } catch (Throwable th) {
                    an.b(this, "performAction", adUnit, th.getMessage());
                    SigmobLog.e("get store package error " + th.getMessage());
                }
            }
            Uri uri2 = Uri.parse(androidMarket.market_url);
            if (com.sigmob.sdk.base.utils.s.a((CharSequence) strA)) {
                strA = com.sigmob.sdk.base.utils.h.a(context, uri2, adUnit.getMarketPackageNameList());
            }
            if (iIntValue == 1) {
                new MiMarketManager.DirectMailStatusReceiver().a(com.sigmob.sdk.b.e(), adUnit);
            }
            com.sigmob.sdk.base.utils.h.a(context, uri2, strA);
        }

        @Override // com.sigmob.sdk.base.common.an
        public boolean a(final Uri uri, int interActionType) {
            String scheme = uri.getScheme();
            return ("HTTP".equalsIgnoreCase(scheme) || "HTTPS".equalsIgnoreCase(scheme)) ? false : true;
        }
    },
    DOWNLOAD_APK(1 == true ? 1 : 0) { // from class: com.sigmob.sdk.base.common.an.6
        @Override // com.sigmob.sdk.base.common.an
        public String a(BaseAdUnit adUnit) {
            if (adUnit == null) {
                return null;
            }
            return adUnit.getLanding_page();
        }

        @Override // com.sigmob.sdk.base.common.an
        protected void a(Context context, Uri uri, ao urlHandler, BaseAdUnit adUnit) throws Exception {
            int interactionType;
            an.b(this, "performAction", adUnit, null);
            if (adUnit == null || (interactionType = adUnit.getInteractionType()) == 2 || interactionType == 3) {
                return;
            }
            String str = "Could not handle download Scheme url: " + uri;
            an.b(this, "performAction", adUnit, str);
            throw new Exception(str);
        }

        @Override // com.sigmob.sdk.base.common.an
        public boolean a(final Uri uri, int interActionType) {
            String scheme = uri.getScheme();
            return "HTTP".equalsIgnoreCase(scheme) || "HTTPS".equalsIgnoreCase(scheme);
        }
    },
    OPEN_WITH_BROWSER(1 == true ? 1 : 0) { // from class: com.sigmob.sdk.base.common.an.7
        @Override // com.sigmob.sdk.base.common.an
        public String a(BaseAdUnit adUnit) {
            if (adUnit == null) {
                return null;
            }
            return adUnit.getLanding_page();
        }

        @Override // com.sigmob.sdk.base.common.an
        protected void a(Context context, Uri uri, ao urlHandler, BaseAdUnit adUnit) throws Exception {
            an.b(this, "performAction", adUnit, null);
            if (adUnit.getInteractionType() != 8) {
                if (urlHandler.a()) {
                    com.sigmob.sdk.base.utils.h.a(context, uri);
                    return;
                } else {
                    h.a(adUnit);
                    AdActivity.a(context, (Class<? extends BaseAdActivity>) AdActivity.class, adUnit.getUuid());
                    return;
                }
            }
            try {
                h.d(adUnit);
                adUnit.setDeeplinkUri(uri);
                com.sigmob.sdk.base.utils.h.a(context, uri, com.sigmob.sdk.b.a());
            } catch (Exception e) {
                an.b(this, "performAction", adUnit, e.getMessage());
                h.d((BaseAdUnit) null);
                adUnit.setDeeplinkUri(null);
                throw e;
            }
        }

        @Override // com.sigmob.sdk.base.common.an
        public boolean a(final Uri uri, int interActionType) {
            return uri != null && ("HTTP".equalsIgnoreCase(uri.getScheme()) || "HTTPS".equalsIgnoreCase(uri.getScheme()));
        }
    },
    NOOP(0 == true ? 1 : 0) { // from class: com.sigmob.sdk.base.common.an.8
        @Override // com.sigmob.sdk.base.common.an
        public String a(BaseAdUnit adUnit) {
            return null;
        }

        @Override // com.sigmob.sdk.base.common.an
        protected void a(Context context, Uri uri, ao urlHandler, BaseAdUnit adUnit) {
            an.b(this, "performAction", adUnit, null);
        }

        @Override // com.sigmob.sdk.base.common.an
        public boolean a(final Uri uri, int interActionType) {
            return false;
        }
    };

    private final boolean i;

    an(boolean requiresUserInteraction) {
        this.i = requiresUserInteraction;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void b(an urlAction, String methodName, BaseAdUnit adUnit, String error) {
        if (urlAction == null || adUnit == null) {
            return;
        }
        String strName = urlAction.name();
        String deeplinkUrl = adUnit.getDeeplinkUrl();
        int interactionType = adUnit.getInteractionType();
        if (com.sigmob.sdk.base.utils.s.b(error)) {
            SigmobLogger.e(strName, methodName + ": error = " + error, new Object[0]);
        } else {
            SigmobLogger.d(strName, methodName + ": deeplinkUrl = " + deeplinkUrl + ", interactionType = " + interactionType, new Object[0]);
        }
    }

    public abstract String a(BaseAdUnit adUnit);

    protected abstract void a(Context context, Uri uri, ao urlHandler, BaseAdUnit adUnit) throws Exception;

    public void a(ao urlHandler, Context context, Uri destinationUri, boolean fromUserInteraction, BaseAdUnit adUnit) throws Exception {
        SigmobLog.d("Ad event URL: " + destinationUri);
        if (this.i && !fromUserInteraction) {
            throw new Exception("Attempted to handle action without user interaction.");
        }
        a(context, destinationUri, urlHandler, adUnit);
    }

    public abstract boolean a(Uri uri, int interActionType);
}
