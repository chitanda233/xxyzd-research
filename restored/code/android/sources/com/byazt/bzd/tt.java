package com.byazt.bzd;

import android.text.TextUtils;
import com.byazt.ete.ic;
import com.byazt.t.DownloadInfo;
import com.sigmob.sdk.base.mta.PointCategory;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 724, 13})
public class tt {
    public static boolean c(JSONObject jSONObject) {
        if (jSONObject == null) {
            return false;
        }
        JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject(PointCategory.APP);
        String strOptString = jSONObjectOptJSONObject != null ? jSONObjectOptJSONObject.optString(com.sigmob.sdk.base.n.p) : null;
        if (TextUtils.isEmpty(strOptString)) {
            strOptString = jSONObject.optString(com.sigmob.sdk.base.n.p);
        }
        return c(strOptString);
    }

    public static boolean c(ic icVar) {
        if (icVar == null) {
            return false;
        }
        com.byazt.ete.n nVarZ = icVar.z();
        String strUj = nVarZ != null ? nVarZ.uj() : null;
        if (TextUtils.isEmpty(strUj)) {
            strUj = icVar.ls();
        }
        return c(strUj);
    }

    private static boolean c(String str) {
        List<DownloadInfo> listTt;
        if (TextUtils.isEmpty(str) || (listTt = com.byazt.zz.ve.zm().tt()) == null) {
            return false;
        }
        for (DownloadInfo downloadInfo : listTt) {
            int status = downloadInfo.getStatus();
            if (str.equals(downloadInfo.getPackageName()) && status == -3) {
                return true;
            }
        }
        return false;
    }
}
