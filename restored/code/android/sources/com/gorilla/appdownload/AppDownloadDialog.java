package com.gorilla.appdownload;

import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.View;
import android.widget.ProgressBar;
import android.widget.TextView;

/* JADX INFO: loaded from: classes3.dex */
final class AppDownloadDialog extends Dialog {
    private final Runnable onCancelDownload;
    private final Runnable onInstallApk;
    private final Runnable onRetryDownload;
    private TextView primaryButton;
    private ProgressBar progressBar;
    private TextView progressText;
    private TextView secondaryButton;
    private TextView statusText;

    static /* synthetic */ boolean lambda$onCreate$0(DialogInterface dialogInterface, int i, KeyEvent keyEvent) {
        return i == 4;
    }

    AppDownloadDialog(Context context, Runnable runnable, Runnable runnable2, Runnable runnable3) {
        super(context);
        requestWindowFeature(1);
        this.onCancelDownload = runnable;
        this.onRetryDownload = runnable2;
        this.onInstallApk = runnable3;
    }

    @Override // android.app.Dialog
    protected void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        setContentView(R.layout.gorilla_app_download_dialog);
        setCancelable(false);
        setCanceledOnTouchOutside(false);
        setOnKeyListener(new DialogInterface.OnKeyListener() { // from class: com.gorilla.appdownload.AppDownloadDialog$$ExternalSyntheticLambda2
            @Override // android.content.DialogInterface.OnKeyListener
            public final boolean onKey(DialogInterface dialogInterface, int i, KeyEvent keyEvent) {
                return AppDownloadDialog.lambda$onCreate$0(dialogInterface, i, keyEvent);
            }
        });
        this.statusText = (TextView) findViewById(R.id.gorilla_app_download_status);
        this.progressText = (TextView) findViewById(R.id.gorilla_app_download_progress_text);
        this.progressBar = (ProgressBar) findViewById(R.id.gorilla_app_download_progress);
        this.secondaryButton = (TextView) findViewById(R.id.gorilla_app_download_secondary);
        TextView textView = (TextView) findViewById(R.id.gorilla_app_download_primary);
        this.primaryButton = textView;
        textView.setEnabled(false);
        this.primaryButton.setAlpha(0.45f);
        this.secondaryButton.setOnClickListener(new View.OnClickListener() { // from class: com.gorilla.appdownload.AppDownloadDialog$$ExternalSyntheticLambda3
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                this.f$0.m130lambda$onCreate$1$comgorillaappdownloadAppDownloadDialog(view);
            }
        });
        this.primaryButton.setOnClickListener(new View.OnClickListener() { // from class: com.gorilla.appdownload.AppDownloadDialog$$ExternalSyntheticLambda4
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                this.f$0.m131lambda$onCreate$2$comgorillaappdownloadAppDownloadDialog(view);
            }
        });
    }

    /* JADX INFO: renamed from: lambda$onCreate$1$com-gorilla-appdownload-AppDownloadDialog, reason: not valid java name */
    /* synthetic */ void m130lambda$onCreate$1$comgorillaappdownloadAppDownloadDialog(View view) {
        this.onCancelDownload.run();
    }

    /* JADX INFO: renamed from: lambda$onCreate$2$com-gorilla-appdownload-AppDownloadDialog, reason: not valid java name */
    /* synthetic */ void m131lambda$onCreate$2$comgorillaappdownloadAppDownloadDialog(View view) {
        this.onInstallApk.run();
    }

    void onProgress(int i) {
        ProgressBar progressBar = this.progressBar;
        if (progressBar == null) {
            return;
        }
        progressBar.setProgress(i);
        this.progressText.setText(i + "%");
        this.statusText.setText(getContext().getString(R.string.gorilla_app_download_downloading));
    }

    void onComplete() {
        ProgressBar progressBar = this.progressBar;
        if (progressBar == null) {
            return;
        }
        progressBar.setProgress(100);
        this.progressText.setText("100%");
        this.statusText.setText(getContext().getString(R.string.gorilla_app_download_complete));
        this.secondaryButton.setText(getContext().getString(R.string.gorilla_app_download_retry));
        this.secondaryButton.setOnClickListener(new View.OnClickListener() { // from class: com.gorilla.appdownload.AppDownloadDialog$$ExternalSyntheticLambda0
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                this.f$0.m128lambda$onComplete$3$comgorillaappdownloadAppDownloadDialog(view);
            }
        });
        this.primaryButton.setText(getContext().getString(R.string.gorilla_app_download_install));
        this.primaryButton.setOnClickListener(new View.OnClickListener() { // from class: com.gorilla.appdownload.AppDownloadDialog$$ExternalSyntheticLambda1
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                this.f$0.m129lambda$onComplete$4$comgorillaappdownloadAppDownloadDialog(view);
            }
        });
        this.primaryButton.setEnabled(true);
        this.primaryButton.setAlpha(1.0f);
    }

    /* JADX INFO: renamed from: lambda$onComplete$3$com-gorilla-appdownload-AppDownloadDialog, reason: not valid java name */
    /* synthetic */ void m128lambda$onComplete$3$comgorillaappdownloadAppDownloadDialog(View view) {
        this.onRetryDownload.run();
    }

    /* JADX INFO: renamed from: lambda$onComplete$4$com-gorilla-appdownload-AppDownloadDialog, reason: not valid java name */
    /* synthetic */ void m129lambda$onComplete$4$comgorillaappdownloadAppDownloadDialog(View view) {
        this.onInstallApk.run();
    }

    void onFailed() {
        TextView textView = this.statusText;
        if (textView == null) {
            return;
        }
        textView.setText(getContext().getString(R.string.gorilla_app_download_failed));
        this.secondaryButton.setText(getContext().getString(R.string.gorilla_app_download_retry));
        this.secondaryButton.setOnClickListener(new View.OnClickListener() { // from class: com.gorilla.appdownload.AppDownloadDialog$$ExternalSyntheticLambda5
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                this.f$0.m132lambda$onFailed$5$comgorillaappdownloadAppDownloadDialog(view);
            }
        });
        this.primaryButton.setText(android.R.string.cancel);
        this.primaryButton.setOnClickListener(new View.OnClickListener() { // from class: com.gorilla.appdownload.AppDownloadDialog$$ExternalSyntheticLambda6
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                this.f$0.m133lambda$onFailed$6$comgorillaappdownloadAppDownloadDialog(view);
            }
        });
        this.primaryButton.setEnabled(true);
        this.primaryButton.setAlpha(1.0f);
    }

    /* JADX INFO: renamed from: lambda$onFailed$5$com-gorilla-appdownload-AppDownloadDialog, reason: not valid java name */
    /* synthetic */ void m132lambda$onFailed$5$comgorillaappdownloadAppDownloadDialog(View view) {
        this.onRetryDownload.run();
    }

    /* JADX INFO: renamed from: lambda$onFailed$6$com-gorilla-appdownload-AppDownloadDialog, reason: not valid java name */
    /* synthetic */ void m133lambda$onFailed$6$comgorillaappdownloadAppDownloadDialog(View view) {
        dismiss();
    }
}
