package com.bun.miitmdid.provider.zte;

import android.os.AsyncTask;
import com.bun.lib.MsaIdInterface;
import com.netease.nis.sdkwrapper.Utils;

/* JADX INFO: loaded from: classes.dex */
public class MsaAsyncTask extends AsyncTask<Void, Void, Boolean> {
    public MsaServiceConnection _conn;
    public MsaIdInterface msaIdInterface;

    public MsaAsyncTask(MsaIdInterface msaIdInterface, MsaServiceConnection msaServiceConnection) {
        this.msaIdInterface = msaIdInterface;
        this._conn = msaServiceConnection;
    }

    /* JADX INFO: renamed from: doInBackground, reason: avoid collision after fix types in other method */
    public Boolean doInBackground2(Void... voidArr) {
        return (Boolean) Utils.rL(new Object[]{this, voidArr, 108, 1594371206384L});
    }

    /* JADX WARN: Type inference failed for: r4v4, types: [java.lang.Boolean, java.lang.Object] */
    @Override // android.os.AsyncTask
    public /* bridge */ /* synthetic */ Boolean doInBackground(Void[] voidArr) {
        ?? RL = Utils.rL(new Object[]{this, voidArr, 109, 1594371206385L});
        return RL;
    }

    /* JADX INFO: renamed from: onPostExecute, reason: avoid collision after fix types in other method */
    public void onPostExecute2(Boolean bool) {
        Utils.rL(new Object[]{this, bool, 110, 1594371206386L});
    }

    @Override // android.os.AsyncTask
    public /* bridge */ /* synthetic */ void onPostExecute(Boolean bool) {
        Utils.rL(new Object[]{this, bool, 111, 1594371206387L});
    }
}
